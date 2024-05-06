namespace Index.Application.Services.AssignmentService;

public interface IAssignmentService
{
    public Task<Assignment?> GetAssignment(int id);
    public Task<bool> CreateAssignment(CreateAssignmentDto dto);
    public Task<bool> DeleteAssignment(int id);
    public Task<bool> RenameAssignment(int id, string name);
    public Task<bool> UpdateLastModifiedDate(int id);
}