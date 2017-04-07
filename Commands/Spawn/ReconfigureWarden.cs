namespace Warden.Messages.Commands.Spawn
{
    public class ReconfigureWarden : SpawnWardenBase
    {
        public string ConfigurationId { get; set; }
        public string Token { get; set; }
    }
}