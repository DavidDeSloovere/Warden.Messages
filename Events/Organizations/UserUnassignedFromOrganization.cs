using System;

namespace Warden.Messages.Events.Organizations
{
    public class UserUnassignedFromOrganization
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }
        public string UnassignedUserId { get; }

        protected UserUnassignedFromOrganization()
        {
        }

        public UserUnassignedFromOrganization(Guid requestId, string userId,
            Guid organizationId, string unassignedUserId)
        {
            RequestId = requestId;
            UserId = userId;
            OrganizationId = organizationId;
            UnassignedUserId = unassignedUserId;
        }          
    }
}