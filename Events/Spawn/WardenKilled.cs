using System;

namespace Warden.Messages.Events.Spawn
{
    public class WardenKilled : WardenSpawnedBase
    {
        protected WardenKilled()
        {
        }

        public WardenKilled(Guid requestId,
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