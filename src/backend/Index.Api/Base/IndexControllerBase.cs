namespace Index.Api.Base;

public abstract class IndexControllerBase : ControllerBase
{
    private readonly IMediator _mediator;

    protected IndexControllerBase(IMediator mediator)
        => _mediator = mediator;

    internal async Task<ActionResult<TResult>> SendRequest<TResult, TRequest>(TRequest? request)
        where TRequest : Request<Response<TResult>>
    {
        if (request is null) return BadRequest();

        var response = await _mediator.Send(request);
        return !string.IsNullOrWhiteSpace(response.Error) || response.ErrorCode is not null
            ? GetErrorResult(response)
            : Ok(response.Result);
    }

    internal async Task<ActionResult<TResult>> SendCommand<TResult, TRequest>(TRequest? command)
        where TRequest : Command<CommandResponse<TResult>>
    {
        if (command is null) return BadRequest();

        var commandResponse = await _mediator.Send(command);
        return !string.IsNullOrWhiteSpace(commandResponse.Error) || commandResponse.ErrorCode is not null
            ? GetErrorResult(commandResponse)
            : Ok(commandResponse.Result);
    }

    private ActionResult GetErrorResult(Response result)
        => result.ErrorCode switch
        {
            _ => Problem(result.Error)
        };
}