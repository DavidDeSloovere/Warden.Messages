using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Users
{
    public class ResetPassword : ICommand
    {
        public Request Request { get; set; }
        public string Email { get; set; }
        public string Endpoint { get; set; }
    }
}