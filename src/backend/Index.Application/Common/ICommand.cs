namespace Index.Application.Common;

public interface ICommand<out TResponse> : IRequest<TResponse>
{
    string CorrellationId { get; }
}

public abstract class Command<TResponse> : ICommand<TResponse>
    where TResponse : ICommandResponse
{
    public string CorrellationId { get; } = Guid.NewGuid().ToString();
}