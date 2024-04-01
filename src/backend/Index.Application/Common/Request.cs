namespace Index.Application.Common;

public abstract class Request<TResponse> : IRequest<TResponse>
    where TResponse : Response
{
}