namespace Index.Domain.Entities.SubjectModule;

public class StudyPlan
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public string UserProfileId { get; set; } = null!;

    public virtual UserProfile UserProfile { get; set; } = null!;
    public virtual ICollection<StudyPlanSubject> StudyPlanSubjects { get; set; } = new List<StudyPlanSubject>();

    public virtual ICollection<StudyPlanRestriction> StudyPlanRestrictions { get; set; } =
        new List<StudyPlanRestriction>();
}