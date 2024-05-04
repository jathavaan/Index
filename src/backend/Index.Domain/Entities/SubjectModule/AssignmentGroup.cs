namespace Index.Domain.Entities.SubjectModule;

public class AssignmentGroup
{
    public int Id { get; set; }
    public string SubjectCode { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public int TotalAssignments { get; set; }
    public string UserProfileId { get; set; } = null!;

    public virtual UserProfile UserProfile { get; set; } = null!;
    public virtual Subject Subject { get; set; } = null!;
    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
}