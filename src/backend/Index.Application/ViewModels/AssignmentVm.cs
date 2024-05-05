namespace Index.Application.ViewModels;

public class AssignmentVm
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public AssignmentPriority Priority { get; set; }
    public AssignmentStatus Status { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? DueDate { get; set; }
}