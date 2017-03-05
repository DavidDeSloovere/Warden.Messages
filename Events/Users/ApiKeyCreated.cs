using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Users
{
    public class ApiKeyCreated : IAuthenticatedEvent
    {
        public Guid RequestId { get;}
        public string UserId { get; }
        public string Name { get; }

        protected ApiKeyCreated()
        {
        }

        public ApiKeyCreated(Guid requestId, string userId, string name)
        {
            RequestId = requestId;
            UserId = userId;
            Name = name;
        }
    }
}