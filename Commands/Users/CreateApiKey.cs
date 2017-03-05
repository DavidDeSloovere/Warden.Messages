using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Users
{
    public class CreateApiKey : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
    }
}