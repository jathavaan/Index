namespace Index.Domain.Entities.SubjectModule;

public class Assignment
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public AssignmentPriority Priority { get; set; }
    public AssignmentStatus Status { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? DueDate { get; set; }
    public int AssignmentGroupId { get; set; }

    public virtual AssignmentGroup AssignmentGroup { get; set; } = null!;
}