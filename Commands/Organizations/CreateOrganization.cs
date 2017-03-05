using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Organizations
{
    public class CreateOrganization : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid OrganizationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}