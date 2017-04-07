using System;

namespace Warden.Messages.Events.Spawn
{
    public class WardenPaused : WardenSpawnedBase
    {
        protected WardenPaused()
        {
        }

        public WardenPaused(Guid requestId,
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