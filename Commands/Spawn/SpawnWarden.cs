namespace Warden.Messages.Commands.Spawn
{
    public class SpawnWarden : SpawnWardenBase
    {
        public string Name { get; set; }
        public string ConfigurationId { get; set; }
        public string Token { get; set; }
    }
}