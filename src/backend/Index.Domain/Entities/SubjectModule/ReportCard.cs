namespace Index.Domain.Entities.SubjectModule;

public class ReportCard
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public string UserProfileId { get; set; } = null!;

    public virtual UserProfile UserProfile { get; set; } = null!;
    public virtual ICollection<ReportCardSubject> ReportCardSubjects { get; set; } = new List<ReportCardSubject>();
}