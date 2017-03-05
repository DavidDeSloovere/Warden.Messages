using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Organizations
{
    public class DeleteWarden : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid WardenId { get; set; }
        public Guid OrganizationId { get; set; }
    }
}