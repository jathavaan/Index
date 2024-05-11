namespace Index.Application.Contracts.SubjectModule.Dtos;

public class CreateAssignmentDto
{
    public int AssignmentGroupId { get; set; }
    public string Name { get; set; } = null!;
    public AssignmentPriority Priority { get; set; }
    public AssignmentStatus Status { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? DueDate { get; set; }
}