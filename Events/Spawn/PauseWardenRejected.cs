using System;

namespace Warden.Messages.Events.Spawn
{
    public class PauseWardenRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected PauseWardenRejected()
        {
        }

        public PauseWardenRejected(Guid requestId, 
            string userId, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}