using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Organizations
{
    public class AssignUserToOrganization : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid OrganizationId { get; set; }
        public string UserToAssignId { get; }
        public string Role { get; set; }
    }
}