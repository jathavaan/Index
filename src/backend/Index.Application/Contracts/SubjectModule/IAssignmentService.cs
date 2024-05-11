using Index.Application.Contracts.SubjectModule.Dtos;

namespace Index.Application.Contracts.SubjectModule;

public interface IAssignmentService
{
    public Task<Assignment?> GetAssignment(int id);
    public Task<bool> CreateAssignment(CreateAssignmentDto dto);
    public Task<bool> DeleteAssignment(int id);
    public Task<AssignmentVm?> UpdateAssignmentName(int id, string name);
    public Task<bool> UpdateLastModifiedDate(int id);
    public Task<AssignmentVm?> UpdateAssignmentPriority(int id, AssignmentPriority priority);
    public Task<AssignmentVm?> UpdateAssignmentStatus(int id, AssignmentStatus status);
    public Task<AssignmentVm?> UpdateAssignmentStartDate(int id, DateTime startDate);
    public Task<AssignmentVm?> UpdateAssignmentDueDate(int id, DateTime dueDate);
}