using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class UnassignUserFromOrganizationRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }
        public Guid OrganizationId { get; }
        public string UserToUnassignId { get; }

        protected UnassignUserFromOrganizationRejected()
        {
        }

        public UnassignUserFromOrganizationRejected(Guid requestId,
            string userId, string code,
            string reason, Guid organizationId,
            string userToUnassignId)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            OrganizationId = organizationId;
            UserToUnassignId = userToUnassignId;
        }
    }
}