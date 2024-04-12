namespace Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;

public class CreateUserProfileCommandDto
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int AccessLevel { get; set; }
}