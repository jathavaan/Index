using Index.Application.Contracts.SubjectModule.Dtos;

namespace Index.Application.Contracts.SubjectModule;

public interface IAssignmentService
{
    public Task<Assignment?> GetAssignment(int id);
    public Task<bool> CreateAssignment(CreateAssignmentDto dto);
    public Task<bool> DeleteAssignment(Assignment assignment);
    public Task<AssignmentVm> UpdateAssignmentName(Assignment assignment, string name);
    public Task<bool> UpdateLastModifiedDate(Assignment assignment);
    public Task<AssignmentVm> UpdateAssignmentPriority(Assignment assignment, AssignmentPriority priority);
    public Task<AssignmentVm> UpdateAssignmentStatus(Assignment assignment, AssignmentStatus status);
    public Task<AssignmentVm> UpdateAssignmentStartDate(Assignment assignment, DateTime startDate);
    public Task<AssignmentVm> UpdateAssignmentDueDate(Assignment assignment, DateTime dueDate);
}