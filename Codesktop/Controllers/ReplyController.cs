﻿using Codesktop.Data;
using Codesktop.Data.Models;
using Codesktop.Models.Reply;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Codesktop.Controllers
{
    [Authorize]
    public class ReplyController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        private readonly IApplicationUser _userService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReplyController(IForum forumService, IPost postService, IApplicationUser userService, UserManager<ApplicationUser> userManager)
        {
            _forumService = forumService;
            _postService = postService;
            _userService = userService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Create(int id)
        {
            var post = _postService.GetById(id);
            var forum = _forumService.GetById(post.Forum.Id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var model = new PostReplyModel
            {
                PostContent = post.Content,
                PostTitle = post.Title,
                PostId = post.Id,

                ForumName = forum.Title,
                ForumId = forum.Id,
                ForumImageUrl = forum.ImageUrl,

                AuthorName = User.Identity.Name,
                AuthorImageUrl = user.ProfileImageUrl,
                AuthorId = user.Id,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("Admin"),

                Created = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReply(PostReplyModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            var reply = BuildReply(model, user);

            await _postService.AddReply(reply);
            await _userService.UpdateUserRating(userId, typeof(PostReply));

            return RedirectToAction("Index", "Post", new { id = model.PostId });
        }

        private PostReply BuildReply(PostReplyModel model, ApplicationUser user)
        {
            var post = _postService.GetById(model.PostId);

            return new PostReply
            {
                Post = post,
                Content = model.ReplyContent,
                Created = DateTime.Now,
                User = user
            };
        }
    }
}