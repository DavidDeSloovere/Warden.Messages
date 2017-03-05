using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Users
{
    public class SetNewPassword : ICommand
    {
        public Request Request { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
    }
}