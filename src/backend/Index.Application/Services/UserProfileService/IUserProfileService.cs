using Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;
using Index.Application.ViewModels;

namespace Index.Application.Services.UserProfileService;

public interface IUserProfileService
{
    public Task<UserProfileVm> CreateUserProfile(CreateUserProfileCommandDto dto);
    public Task<UserProfileVm?> GetUserProfileByIdOrEmail(string idOrEmail);
    public Task<bool> CheckUserCredentials(string email, string password);
}