namespace Index.Infrastructure.Services.SubjectModule;

public class SubjectService : ISubjectService
{
    private readonly IndexDbContext _context;
    private readonly IRedisCacheService _redisCacheService;

    public SubjectService(IndexDbContext context, IRedisCacheService redisCacheService)
    {
        _context = context;
        _redisCacheService = redisCacheService;
    }

    public async Task<List<Subject>> GetAllSubjects()
    {
        return await _context.Subjects.ToListAsync();
    }

    public async Task<Subject?> GetSubject(string subjectCode)
    {
        var cachedSubject = await _redisCacheService.Get<Subject>(subjectCode);
        if (cachedSubject is not null) return cachedSubject;

        var subject = await _context.Subjects
            .Where(x => x.SubjectCode == subjectCode)
            .FirstOrDefaultAsync();

        if (subject is not null)
            await _redisCacheService.Set(subjectCode, subject, DateTimeOffset.Now.AddHours(2));

        return subject;
    }

    public async Task<bool> CreateSubject(string subjectCode, string name, double credit)
    {
        if (await GetSubject(subjectCode) is not null)
            throw new Exception($"Subject already exists with subject code {subjectCode}");

        var subject = new Subject
        {
            SubjectCode = subjectCode,
            Name = name,
            Credits = credit
        };

        _context.Subjects.Add(subject);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> UpdateSubject(Subject subject, string? name, double? credit)
    {
        if (name is null && credit is null) return false;
        if (name is not null) subject.Name = name;
        if (credit is not null) subject.Credits = (double)credit;

        _context.Subjects.Update(subject);
        await _context.SaveChangesAsync();
        await _redisCacheService.Set(subject.SubjectCode, subject);

        return true;
    }

    public async Task<bool> DeleteSubject(Subject subject)
    {
        _context.Subjects.Remove(subject);
        await _context.SaveChangesAsync();
        await _redisCacheService.Remove(subject.SubjectCode);
        return true;
    }
}