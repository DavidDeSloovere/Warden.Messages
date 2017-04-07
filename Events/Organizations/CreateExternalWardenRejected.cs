using System;

namespace Warden.Messages.Events.Organizations
{
    public class CreateExternalWardenRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }
        public Guid OrganizationId { get; }

        protected CreateExternalWardenRejected()
        {
        }

        public CreateExternalWardenRejected(Guid requestId,
            string userId, string code,
            string reason, Guid organizationId)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            OrganizationId = organizationId;
        }
    }
}