namespace Index.Application.ViewModels;

public class UserProfileVm
{
    public string FirstName { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public UserProfileAccessLevel AccessLevel { get; set; }
}