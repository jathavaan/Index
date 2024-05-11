namespace Index.Application.Middleware;

internal class CommandValidatorPipelineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
    where TResponse : Response, new()
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public CommandValidatorPipelineBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var context = new ValidationContext<TRequest>(request);
        var errorsDictonary = _validators
            .Select(x => x.Validate(context))
            .SelectMany(x => x.Errors)
            .Where(x => x != null)
            .GroupBy(
                x => x.PropertyName,
                x => x.ErrorMessage,
                (propertyName, errorMessages) => new
                {
                    Key = propertyName,
                    Values = errorMessages.Distinct()
                }
            )
            .ToDictionary(x => x.Key, xmlAttribute => xmlAttribute.Values);

        if (errorsDictonary.Count == 0) return await next();
        var errorLists = errorsDictonary.Values
            .ToList()
            .Select(item => item.FirstOrDefault())
            .ToList();

        return new TResponse
        {
            Error = string.Join("\r\n", errorLists),
            ErrorCode = IndexErrorCode.RequestValidationFailed
        };
    }
}