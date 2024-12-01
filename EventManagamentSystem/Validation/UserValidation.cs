using System;
using System.Text.RegularExpressions;
using EventManagementSystem.Models;

namespace EventManagementSystem.Validation
{
    public static class UserValidation
    {
        public static void ValidateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name) || user.Name.Length > 100)
                throw new Exception("User name must be between 1 and 100 characters.");

            if (string.IsNullOrWhiteSpace(user.Email) || !IsValidEmail(user.Email))
                throw new Exception("Invalid email address.");

            if (string.IsNullOrWhiteSpace(user.Password) || user.Password.Length < 8 || user.Password.Length > 16)
                throw new Exception("Password must be between 8 and 16 characters.");
        }

        private static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
