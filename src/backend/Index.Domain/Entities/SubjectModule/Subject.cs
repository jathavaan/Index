namespace Index.Domain.Entities.SubjectModule;

public class Subject
{
    public string SubjectCode { get; set; } = null!;
    public string Name { get; set; } = null!;
    public SubjectType Type { get; set; }
    public double Credits { get; set; }

    public virtual ICollection<ReportCardSubject> ReportCardSubjects { get; set; } = new List<ReportCardSubject>();
    public virtual ICollection<StudyPlanSubject> StudyPlanSubjects { get; set; } = new List<StudyPlanSubject>();
    public virtual ICollection<AssignmentGroup> AssignmentGroups { get; set; } = new List<AssignmentGroup>();
}