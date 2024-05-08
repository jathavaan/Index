namespace Index.Domain.Entities.SubjectModule;

public class StudyPlanRestriction
{
    public int Id { get; set; }
    public SubjectType SubjectType { get; set; }
    public double RequiredCredits { get; set; }
    public int Year { get; set; }
    public Semester Semester { get; set; }
    public int StudyPlanId { get; set; }

    public virtual StudyPlan StudyPlan { get; set; } = null!;
}