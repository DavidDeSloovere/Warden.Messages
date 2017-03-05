using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class WardenDeleted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid WardenId { get; }
        public Guid OrganizationId { get; }

        protected WardenDeleted()
        {
        }

        public WardenDeleted(Guid requestId, string userId,
            Guid wardenId, Guid organizationId)
        {
            RequestId = requestId;
            UserId = userId;
            WardenId = wardenId;
            OrganizationId = organizationId;
        }
    }
}