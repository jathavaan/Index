namespace Index.Infrastructure.Services.SubjectModule;

public class SubjectService : ISubjectService
{
    private readonly IndexDbContext _context;

    public SubjectService(IndexDbContext context)
    {
        _context = context;
    }

    public async Task<List<Subject>> GetAllSubjects()
    {
        return await _context.Subjects.ToListAsync();
    }

    public async Task<Subject?> GetSubject(string subjectCode)
    {
        return await _context.Subjects
            .Where(x => x.SubjectCode == subjectCode)
            .FirstOrDefaultAsync();
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

        return true;
    }

    public async Task<bool> DeleteSubject(Subject subject)
    {
        _context.Subjects.Remove(subject);
        await _context.SaveChangesAsync();
        return true;
    }
}