using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class UserAssignedToOrganization : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }
        public string AssignedUserId { get; }

        protected UserAssignedToOrganization()
        {
        }

        public UserAssignedToOrganization(Guid requestId, string userId,
            Guid organizationId, string assignedUserId)
        {
            RequestId = requestId;
            UserId = userId;
            OrganizationId = organizationId;
            AssignedUserId = assignedUserId;
        }        
    }
}