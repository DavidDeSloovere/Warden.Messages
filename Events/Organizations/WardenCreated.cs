using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class WardenCreated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid WardenId { get; }
        public string Name { get; }
        public Guid OrganizationId { get; }
        public DateTime CreatedAt { get; }
        public bool Enabled { get;}

        protected WardenCreated()
        {
        }

        public WardenCreated(Guid requestId,
            string userId,
            Guid wardenId,
            string name,
            Guid organizationId,
            DateTime createdAt,
            bool enabled)
        {
            RequestId = requestId;
            UserId = userId;
            WardenId = wardenId;
            Name = name;
            OrganizationId = organizationId;
            CreatedAt = createdAt;
            Enabled = enabled;
        }
    }
}