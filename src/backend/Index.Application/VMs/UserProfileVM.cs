namespace Index.Application.VMs;

public class UserProfileVM
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public UserProfileAccessLevel AccessLevel { get; set; }
}