using System;

namespace Warden.Messages.Events.Organizations
{
    public class ExternalWardenCreated
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }
        public Guid WardenId { get; }
        public string Name { get; }
        public string Region { get; }
        public DateTime CreatedAt { get; }

        protected ExternalWardenCreated()
        {
        }

        public ExternalWardenCreated(Guid requestId,
            string userId,
            Guid organizationId,
            Guid wardenId,
            string name,
            DateTime createdAt)
        {
            RequestId = requestId;
            UserId = userId;
            OrganizationId = organizationId;
            WardenId = wardenId;
            Name = name;
            CreatedAt = createdAt;
        }
    }
}