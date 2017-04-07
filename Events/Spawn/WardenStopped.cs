using System;

namespace Warden.Messages.Events.Spawn
{
    public class WardenStopped : WardenSpawnedBase
    {
        protected WardenStopped()
        {
        }

        public WardenStopped(Guid requestId,
            string userId,
            Guid organizationId,
            Guid wardenId,
            string name,
            DateTime createdAt) 
            : base(requestId, userId, organizationId, wardenId, name)
        {
        }
    }
}