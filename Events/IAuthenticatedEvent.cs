namespace Warden.Messages.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        string UserId { get; }
    }
}