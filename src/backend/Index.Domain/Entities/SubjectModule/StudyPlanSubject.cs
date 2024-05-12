namespace Index.Domain.Entities.SubjectModule;

public class StudyPlanSubject
{
    public int StudyPlanId { get; set; }
    public string SubjectCode { get; set; } = null!;
    public int Year { get; set; }
    public Semester Semester { get; set; }

    public virtual StudyPlan StudyPlan { get; set; } = null!;
    public virtual Subject Subject { get; set; } = null!;
}