using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Users
{
    public class SignedOut : IEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid SessionId { get; }

        protected SignedOut()
        {
        }

        public SignedOut(Guid requestId, string userId, Guid sessionId)
        {
            RequestId = requestId;
            UserId = userId;
            SessionId = sessionId;
        }
    }
}