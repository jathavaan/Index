namespace Index.Domain.Entities.SubjectModule;

public class Assignment
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public AssignmentPriority AssignmentPriority { get; set; }
    public AssignmentStatus AssignmentStatus { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? DueDate { get; set; }
    public int AssignmentGroupId { get; set; }

    public virtual AssignmentGroup AssignmentGroup { get; set; } = null!;
}