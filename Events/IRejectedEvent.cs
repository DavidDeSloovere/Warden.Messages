namespace Warden.Messages.Events
{
    public interface IRejectedEvent : IAuthenticatedEvent
    {
        string Reason { get; }
        string Code { get; }
    }
}