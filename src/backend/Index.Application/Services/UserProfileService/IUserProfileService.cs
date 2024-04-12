using Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;

namespace Index.Application.Services.UserProfileService;

public interface IUserProfileService
{
    public Task<UserProfileVM> CreateUserProfile(CreateUserProfileCommandDto dto);
    public Task<UserProfileVM?> GetUserProfileByIdOrEmail(string idOrEmail);
    public Task<bool> CheckUserCredentials(string email, string password);
}