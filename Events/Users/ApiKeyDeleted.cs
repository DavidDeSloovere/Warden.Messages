using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Users
{
    public class ApiKeyDeleted : IAuthenticatedEvent
    {
        public Guid RequestId { get;}
        public string UserId { get; }
        public string Name { get; }

        protected ApiKeyDeleted()
        {
        }

        public ApiKeyDeleted(Guid requestId, string userId, string name)
        {
            RequestId = requestId;
            UserId = userId;
            Name = name;
        }
    }
}