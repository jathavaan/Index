namespace Index.Api.Base;

public abstract class IndexControllerBase(IMediator mediator) : ControllerBase
{
    internal async Task<ActionResult<TResult>> SendRequest<TResult, TRequest>(TRequest? request)
        where TRequest : Request<Response<TResult>>
    {
        if (request is null) return BadRequest();

        var response = await mediator.Send(request);
        return !string.IsNullOrWhiteSpace(response.Error) || response.ErrorCode is not null
            ? GetErrorResult(response)
            : Ok(response.Result);
    }

    internal async Task<ActionResult<TResult>> SendCommand<TResult, TRequest>(TRequest? command)
        where TRequest : Command<CommandResponse<TResult>>
    {
        if (command is null) return BadRequest();

        var commandResponse = await mediator.Send(command);
        return !string.IsNullOrWhiteSpace(commandResponse.Error) || commandResponse.ErrorCode is not null
            ? GetErrorResult(commandResponse)
            : Ok(commandResponse.Result);
    }

    private ActionResult GetErrorResult(Response result)
        => result.ErrorCode switch
        {
            IndexErrorCode.AlreadyExists => Problem(result.Error),
            IndexErrorCode.Forbidden => Forbid(result.Error!),
            IndexErrorCode.NotFound => NotFound(result.Error),
            _ => Problem(result.Error)
        };
}