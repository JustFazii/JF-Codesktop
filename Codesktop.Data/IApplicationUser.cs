﻿using Codesktop.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codesktop.Data
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();

        Task SetProfileImage(string id, Uri uri);
        Task UpdateUserRating(string id, Type type);
    }
}
