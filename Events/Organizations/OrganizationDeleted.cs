using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class OrganizationDeleted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Guid OrganizationId { get; }
        public string UserId { get; }

        protected OrganizationDeleted()
        {
        }

        public OrganizationDeleted(Guid requestId, Guid organizationId, string userId)
        {
            RequestId = requestId;
            OrganizationId = organizationId;
            UserId = userId;
        }
    }
}