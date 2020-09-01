﻿using EasyRoster.API.Context;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class UserDomain : IUserDomain
    {
        public UserDomain(UserContext context)
        {
            _context = context;
            _repository = new UserRepository(_context);
        }

        public void Delete(User entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public User GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        //public User GetByName(string UserName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<User> _UsersWithName = _repository.Get( e => e.Name == UserName).ToList();
        //    return 
        //}

        public void Insert(User entity)
        {
            _repository.Insert(entity);
        }

        public void Update(User entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }

        private readonly UserContext _context;
        private readonly UserRepository _repository;
    }
}
