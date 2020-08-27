﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Models;

namespace EasyRoster.API.Domains.Interface
{
    public interface IUserDomain
    {
        void Delete(User entityToDelete);
        User GetByID(object id);
        void Insert(User entity);
        void Update(User entityToUpdate);
    }
}
