using Codesktop.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codesktop.Data
{
    public interface IForum
    {
        Models.Forum GetById(int id);
        IEnumerable<Models.Forum> GetAll();
        IEnumerable<ApplicationUser> GetActiveUsers(int id);

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
        bool HasRecentPost(int id);
    }
}
