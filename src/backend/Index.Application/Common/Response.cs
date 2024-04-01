namespace Index.Application.Common;

public abstract class Response
{
    public IndexErrorCode? ErrorCode { get; set; }
    public string? Error { get; set; }
}

public class Response<T> : Response
{
    public T? Result { get; set; }
}