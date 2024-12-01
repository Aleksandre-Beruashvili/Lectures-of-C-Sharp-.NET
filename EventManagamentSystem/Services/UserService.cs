using EventManagementSystem.DataAccess;
using EventManagementSystem.Interfaces;
using EventManagementSystem.Models;
using EventManagementSystem.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventManagementSystem.Services
{
    public class UserService : IUserService
    {
        private readonly JsonDataAccess _dataAccess;

        public UserService(JsonDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void RegisterUser(User user)
        {
            UserValidation.ValidateUser(user);

            var users = _dataAccess.LoadUsers();

            if (users.Any(u => u.Email == user.Email))
                throw new Exception("Email already exists.");

            user.UserId = users.Any() ? users.Max(u => u.UserId) + 1 : 1;
            users.Add(user);
            _dataAccess.SaveUsers(users);
        }

        public List<User> GetUsers()
        {
            return _dataAccess.LoadUsers();
        }
    }
}
