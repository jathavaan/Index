
namespace Index.Application.Contracts.UserProfileModule;

public interface IUserProfileService
{
    public Task<UserProfileVm> CreateUserProfile(CreateUserProfileCommandDto dto);
    public Task<UserProfileVm?> GetUserProfileByIdOrEmail(string idOrEmail);
    public Task<bool> CheckUserCredentials(string email, string password);
}