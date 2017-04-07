using System;

namespace Warden.Messages.Events.Spawn
{
    public class WardenSpawned : WardenSpawnedBase
    {
        public DateTime CreatedAt { get; }

        protected WardenSpawned()
        {
        }

        public WardenSpawned(Guid requestId,
            string userId,
            Guid organizationId,
            Guid wardenId,
            string name,
            DateTime createdAt) 
            : base(requestId, userId, organizationId, wardenId, name)
        {
            CreatedAt = createdAt;
        }
    }
}