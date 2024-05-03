namespace Index.Domain.Entities.SubjectModule;

public class Subject
{
    public int Id { get; set; }
    public string SubjectCode { get; set; } = null!;
    public string Name { get; set; } = null!;
    public double Credit { get; set; }

    public virtual ICollection<ReportCardSubject> ReportCardSubjects { get; set; } = new List<ReportCardSubject>();
}