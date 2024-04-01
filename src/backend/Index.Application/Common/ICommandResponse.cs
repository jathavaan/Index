using Index.Application.Events;

namespace Index.Application.Common;

public interface ICommandResponse
{
    ICollection<IEvent> Events { get; }
    ICollection<BusEvent> BusEvents { get; }
}

public class CommandResponse<T> : Response<T>, ICommandResponse
{
    public ICollection<IEvent> Events { get; } = new List<IEvent>();
    public ICollection<BusEvent> BusEvents { get; } = new List<BusEvent>();
}