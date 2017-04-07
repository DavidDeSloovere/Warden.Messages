using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Spawn
{
    public abstract class SpawnWardenBase : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set;  }
        public Guid OrganizationId { get; set; }
        public Guid WardenId { get; set; }
        public string Region { get; set; }
    }
}