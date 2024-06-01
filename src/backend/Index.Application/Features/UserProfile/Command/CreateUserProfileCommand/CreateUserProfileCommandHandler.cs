namespace Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;

public class CreateUserProfileCommandHandler : IRequestHandler<CreateUserProfileCommand, CommandResponse<UserProfileVm>>
{
    private readonly IUserProfileService _userProfileService;

    public CreateUserProfileCommandHandler(IUserProfileService userProfileService)
    {
        _userProfileService = userProfileService;
    }

    public async Task<CommandResponse<UserProfileVm>> Handle(CreateUserProfileCommand request,
        CancellationToken cancellationToken)
    {
        if (await _userProfileService.GetUserProfileVmByIdOrEmail(request.Dto.Email) is not null)
            return new CommandResponse<UserProfileVm>
            {
                ErrorCode = IndexErrorCode.AlreadyExists,
                Error = $"{request.Dto.Email} is taken. Please login with the existing account or try another email."
            };

        var userProfile = await _userProfileService.CreateUserProfile(request.Dto);
        if (userProfile is null)
        {
            return new CommandResponse<UserProfileVm>()
            {
                ErrorCode = IndexErrorCode.BusinessRuleValidation,
                Error = "Failed to create user profile."
            };
        }

        return new CommandResponse<UserProfileVm>
        {
            Result = userProfile
        };
    }
}