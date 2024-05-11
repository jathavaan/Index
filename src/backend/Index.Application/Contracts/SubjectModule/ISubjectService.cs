namespace Index.Application.Contracts.SubjectModule;

public interface ISubjectService
{
    public Task<List<Subject>> GetAllSubjects();
    public Task<Subject?> GetSubject(string subjectCode);
    public Task<bool> CreateSubject(string subjectCode, string name, double credit);
    public Task<bool> UpdateSubject(Subject subject, string? name, double? credit);
    public Task<bool> DeleteSubject(Subject subject);
}