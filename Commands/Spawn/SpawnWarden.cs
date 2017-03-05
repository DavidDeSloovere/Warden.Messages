using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Spawn
{
    public class SpawnWarden : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set;  }
        public Guid WardenSpawnId { get; set; }
        public string ConfigurationId { get; set; }
        public object Configuration { get; set; }
        public string Token { get; set; }
        public string Region { get; set; }
    }
}