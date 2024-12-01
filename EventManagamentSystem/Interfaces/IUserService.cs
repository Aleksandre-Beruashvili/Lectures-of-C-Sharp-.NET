using System.Collections.Generic;
using EventManagementSystem.Models;

namespace EventManagementSystem.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(User user);
        List<User> GetUsers();
    }
}
