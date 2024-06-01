namespace Index.Application.Contracts.UserProfileModule;

public interface IUserProfileService
{
    public Task<UserProfileVm?> CreateUserProfile(CreateUserProfileCommandDto dto);
    public Task<UserProfile?> GetUserProfileByIdOrEmail(string idOrEmail);
    public Task<UserProfileVm?> GetUserProfileVmByIdOrEmail(string idOrEmail);
}