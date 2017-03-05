using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Spawn
{
    public class RunWardenProcess : ICommand
    {
        public Request Request { get; set; }
        public string ConfigurationId { get; set; }
        public string Token { get; set; }
    }
}