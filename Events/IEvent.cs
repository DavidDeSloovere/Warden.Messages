using System;

namespace Warden.Messages.Events
{
public interface IEvent
{
    Guid RequestId { get; }
}
}