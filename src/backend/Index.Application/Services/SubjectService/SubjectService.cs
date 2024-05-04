using Microsoft.EntityFrameworkCore;

namespace Index.Application.Services.SubjectService;

public class SubjectService(IndexDbContext indexDbContext) : ISubjectService
{
    public async Task<List<Subject>> GetAllSubjects()
        => await indexDbContext.Subjects.ToListAsync();

    public async Task<Subject?> GetSubject(string subjectCode)
        => await indexDbContext.Subjects
            .Where(x => x.SubjectCode == subjectCode)
            .FirstOrDefaultAsync();

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

        indexDbContext.Subjects.Add(subject);
        await indexDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> UpdateSubject(string subjectCode, string? name, double? credit)
    {
        if (name is null && credit is null) return false;

        var subject = await GetSubject(subjectCode);
        if (subject is null) throw new Exception($"Subject with subject code {subjectCode} does not exist");

        if (name is not null) subject.Name = name;
        if (credit is not null) subject.Credits = (double)credit!;

        indexDbContext.Subjects.Update(subject);
        await indexDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteSubject(string subjectCode)
    {
        var subject = await GetSubject(subjectCode);
        if (subject is null)
        {
            return false;
        }

        indexDbContext.Subjects.Remove(subject);
        await indexDbContext.SaveChangesAsync();
        return true;
    }
}