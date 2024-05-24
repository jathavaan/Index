namespace Index.Domain.Entities.UserModule;

public class UserProfile : IdentityUser
{
    // public new string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = null!;
    public string Surname { get; set; } = null!;
    // public string Email { get; set; } = null!;
    // public string Password { get; set; } = null!;
    public UserProfileAccessLevel AccessLevel { get; set; }

    public virtual ICollection<ReportCard> ReportCards { get; set; } = new List<ReportCard>();
    public virtual ICollection<StudyPlan> StudyPlans { get; set; } = new List<StudyPlan>();
    public virtual ICollection<AssignmentGroup> AssignmentGroups { get; set; } = new List<AssignmentGroup>();
}