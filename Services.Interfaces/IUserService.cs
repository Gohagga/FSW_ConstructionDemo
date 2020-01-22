using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.FSW.Users
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}
