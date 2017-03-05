using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class OrganizationUpdated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Guid OrganizationId { get; }
        public string UserId { get; }

        protected OrganizationUpdated()
        {
        }

        public OrganizationUpdated(Guid requestId, Guid organizationId, string userId)
        {
            RequestId = requestId;
            OrganizationId = organizationId;
            UserId = userId;
        }
    }
}