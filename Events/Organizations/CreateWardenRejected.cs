using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class CreateWardenRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }
        public string Name { get; }
        public Guid OrganizationId { get; }

        public CreateWardenRejected(Guid requestId,
            string userId, string code,
            string reason, string name,
            Guid organizationId)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            Name = name;
            OrganizationId = organizationId;
        }
    }
}