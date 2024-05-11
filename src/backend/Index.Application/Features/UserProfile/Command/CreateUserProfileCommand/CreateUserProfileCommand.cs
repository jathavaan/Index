namespace Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;

public class CreateUserProfileCommand(CreateUserProfileCommandDto dto) : Command<CommandResponse<UserProfileVm>>
{
    public CreateUserProfileCommandDto Dto { get; set; } = dto;
}

public class CreateUserProfileCommandDto
{
    public string FirstName { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public int AccessLevel { get; set; }
}