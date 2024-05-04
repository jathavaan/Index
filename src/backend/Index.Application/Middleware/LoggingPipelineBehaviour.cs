using Microsoft.Extensions.Logging;

namespace Index.Application.Middleware;

public class LoggingPipelineBehaviour<TRequest, TResponse>(
    ILogger<LoggingPipelineBehaviour<TRequest, TResponse>> logger
) : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
{
    private readonly ILogger<LoggingPipelineBehaviour<TRequest, TResponse>> _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        try
        {
            var result = await next().ConfigureAwait(false);
            if (result is not Response response ||
                (string.IsNullOrWhiteSpace(response.Error) && response.Error is null))
            {
                return result;
            }

            var errorMessage = !string.IsNullOrWhiteSpace(response.Error)
                ? response.Error
                : response.ErrorCode.ToString();

            _logger.LogError(errorMessage);

            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{request.GetType().FullName} : {e.Message}", e.GetBaseException());
            throw;
        }
    }
}