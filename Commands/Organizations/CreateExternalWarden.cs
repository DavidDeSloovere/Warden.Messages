using System;

namespace Warden.Messages.Commands.Organizations
{
    public class CreateExternalWarden : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set;  }
        public Guid OrganizationId { get; set; }
        public Guid WardenId { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }
    }
}