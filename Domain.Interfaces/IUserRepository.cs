using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        IEnumerable<User> GetUsers();
    }
}
