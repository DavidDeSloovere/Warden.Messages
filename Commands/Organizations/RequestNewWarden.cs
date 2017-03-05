using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Organizations
{
    public class RequestNewWarden : IFeatureRequestCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid WardenId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enabled { get; set; }
    }
}