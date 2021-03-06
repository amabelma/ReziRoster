﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReziRoster.API.Models;

namespace ReziRoster.API.Domains.Interface
{
    public interface ITeamDomain
    {
        void Delete(Team entityToDelete);
        Team GetByID(object id);
        void Insert(Team entity);
        void Update(Team entityToUpdate);
    }
}
