using StackExchange.Redis;

namespace Index.Infrastructure.Services.SubjectModule;

public class SubjectCacheService : ISubjectCacheService
{
    private readonly IConnectionMultiplexer _connectionMultiplexer;
    private readonly ISubjectService _subjectService;

    public SubjectCacheService(IConnectionMultiplexer connectionMultiplexer, ISubjectService subjectService)
    {
        _connectionMultiplexer = connectionMultiplexer;
        _subjectService = subjectService;
    }
}