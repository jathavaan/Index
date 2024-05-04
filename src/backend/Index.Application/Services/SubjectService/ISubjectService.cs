namespace Index.Application.Services.SubjectService;

public interface ISubjectService
{
    public Task<List<Subject>> GetAllSubjects();
    public Task<Subject?> GetSubject(string subjectCode);
    public Task<bool> CreateSubject(string subjectCode, string name, double credit);
    public Task<bool> UpdateSubject(string subjectCode, string? name, double? credit);
    public Task<bool> DeleteSubject(string subjectCode);
}