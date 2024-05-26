namespace Index.Application.Contracts.Common;

public interface IRedisCacheService
{
    public Task<T?> Get<T>(string key);
    public Task Set<T>(string key, T value, DateTimeOffset? expirationTime = null);
    public Task<bool> Remove(string key);
}