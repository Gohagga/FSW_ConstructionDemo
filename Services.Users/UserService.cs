using Domain.Entities;
using Domain.Interfaces.Repositories;
using Services.Interfaces.FSW.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.FSW.Users
{
    class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _repository.GetUsers();
        }
    }
}
