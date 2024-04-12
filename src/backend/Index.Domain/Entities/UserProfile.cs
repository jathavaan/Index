namespace Index.Domain.Entities;

public partial class UserProfile
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserProfileAccessLevel AccessLevel { get; set; }
}