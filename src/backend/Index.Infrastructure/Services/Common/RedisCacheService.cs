using Index.Application.Contracts.Common;
using StackExchange.Redis;

namespace Index.Infrastructure.Services.Common;

public class RedisCacheService : IRedisCacheService
{
    private readonly IDatabase _redisDb;

    public RedisCacheService(IConnectionMultiplexer connectionMultiplexer)
    {
        _redisDb = connectionMultiplexer.GetDatabase();
    }

    public async Task<T?> Get<T>(string key)
    {
        var value = await _redisDb.StringGetAsync(key);
        return value.HasValue ? JsonSerializer.Deserialize<T>(value!) : default;
    }

    public Task Set<T>(string key, T value, DateTimeOffset? expirationTime = null)
    {
        var serializedValue = JsonSerializer.Serialize(value);
        var expiryTime = expirationTime?.DateTime.Subtract(DateTime.Now);
        return _redisDb.StringSetAsync(key, serializedValue, expiryTime);
    }

    public async Task<bool> Remove(string key)
    {
        var keyExists = await _redisDb.KeyExistsAsync(key);
        if (keyExists) return await _redisDb.KeyDeleteAsync(key);
        return false;
    }
}