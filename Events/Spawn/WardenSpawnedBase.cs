using System;

namespace Warden.Messages.Events.Spawn
{
    public abstract class WardenSpawnedBase : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }
        public Guid WardenId { get; }
        public string Name { get; }
        public string Region { get; }

        protected WardenSpawnedBase()
        {
        }

        public WardenSpawnedBase(Guid requestId,
            string userId,
            Guid organizationId,
            Guid wardenId,
            string name)
        {
            RequestId = requestId;
            UserId = userId;
            OrganizationId = organizationId;
            WardenId = wardenId;
            Name = name;
        }
    }
}