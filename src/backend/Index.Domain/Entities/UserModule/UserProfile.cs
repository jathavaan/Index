namespace Index.Domain.Entities.UserModule;

public class UserProfile
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public UserProfileAccessLevel AccessLevel { get; set; }

    public virtual ICollection<ReportCard> ReportCards { get; set; } = new List<ReportCard>();
}