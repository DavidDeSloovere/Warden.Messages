using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.WardenChecks
{
    public class WardenCheckResultProcessed : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }
        public Guid WardenId { get; }
        public object CheckResult { get; }

        protected WardenCheckResultProcessed()
        {
        }

        public WardenCheckResultProcessed(Guid requestId,
            string userId,
            Guid organizationId,
            Guid wardenId,
            object checkResult)
        {
            RequestId = requestId;
            UserId = userId;
            OrganizationId = organizationId;
            WardenId = wardenId;
            CheckResult = checkResult;
        }
    }
}