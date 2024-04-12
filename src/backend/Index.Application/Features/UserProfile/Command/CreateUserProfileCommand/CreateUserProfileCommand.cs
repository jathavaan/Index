namespace Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;

public class CreateUserProfileCommand : Command<CommandResponse<UserProfileVM>>
{
    public CreateUserProfileCommandDto Dto { get; set; }

    public CreateUserProfileCommand(CreateUserProfileCommandDto dto)
    {
        Dto = dto;
    }
}