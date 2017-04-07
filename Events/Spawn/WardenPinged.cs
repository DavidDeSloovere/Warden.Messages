using System;

namespace Warden.Messages.Events.Spawn
{
    public class WardenPinged : WardenSpawnedBase
    {
        protected WardenPinged()
        {
        }

        public WardenPinged(Guid requestId,
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