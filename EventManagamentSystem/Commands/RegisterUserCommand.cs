using EventManagementSystem.Interfaces;
using EventManagementSystem.Models;

namespace EventManagementSystem.Commands
{
    public class RegisterUserCommand : ICommand
    {
        private readonly IUserService _userService;
        private readonly User _user;

        public RegisterUserCommand(IUserService userService, User user)
        {
            _userService = userService;
            _user = user;
        }

        public void Execute()
        {
            _userService.RegisterUser(_user);
        }
    }
}
