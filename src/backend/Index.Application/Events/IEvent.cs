namespace Index.Application.Events;

public interface IEvent : INotification
{
    string? CorrelationId { get; set; }
}

public class Event : IEvent
{
    public Event(string? correlationId)
    {
        CorrelationId = correlationId;
    }

    public string? CorrelationId { get; set; }
}