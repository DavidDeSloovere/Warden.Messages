using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class DeleteWardenRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }
        public Guid OrganizationId { get; }
        public Guid WardenId { get; }

        protected DeleteWardenRejected()
        {
        }

        public DeleteWardenRejected(Guid requestId,
            string userId, string code,
            string reason, Guid organizationId,
            Guid wardenId)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            OrganizationId = organizationId;
            WardenId = wardenId;
        }
    }
}