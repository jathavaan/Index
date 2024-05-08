namespace Index.Domain.Entities.SubjectModule;

public class StudyPlanSubject
{
    public int StudyPlanId { get; set; }
    public string SubjectCode { get; set; } = null!;

    public virtual StudyPlan StudyPlan { get; set; } = null!;
    public virtual Subject Subject { get; set; } = null!;
}