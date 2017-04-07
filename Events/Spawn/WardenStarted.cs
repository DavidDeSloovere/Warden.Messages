using System;

namespace Warden.Messages.Events.Spawn
{
    public class WardenStarted : WardenSpawnedBase
    {
        protected WardenStarted()
        {
        }

        public WardenStarted(Guid requestId,
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