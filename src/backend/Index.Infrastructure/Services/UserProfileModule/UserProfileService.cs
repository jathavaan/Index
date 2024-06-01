using Microsoft.AspNetCore.Identity;

namespace Index.Infrastructure.Services.UserProfileModule;

public class UserProfileService : IUserProfileService
{
    private readonly UserManager<UserProfile> _userManager;
    private readonly ILogger<UserProfileService> _logger;

    public UserProfileService(UserManager<UserProfile> userManager, ILogger<UserProfileService> logger)
    {
        _userManager = userManager;
        _logger = logger;
    }

    public async Task<UserProfileVm?> CreateUserProfile(CreateUserProfileCommandDto dto)
    {
        var userProfile = new UserProfile
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = dto.FirstName,
            Surname = dto.Surname,
            Email = dto.Email.ToLower(),
            UserName = dto.Email.ToLower(),
            AccessLevel = (UserProfileAccessLevel)dto.AccessLevel
        };

        var hashedPassword = _userManager.PasswordHasher.HashPassword(userProfile, dto.Password);
        var result = await _userManager.CreateAsync(userProfile, hashedPassword);

        if (!result.Errors.Any())
        {
            return new UserProfileVm
            {
                Id = userProfile.Id,
                FirstName = userProfile.FirstName,
                Surname = userProfile.Surname,
                Email = userProfile.Email,
                AccessLevel = userProfile.AccessLevel
            };
        }

        var errors = result.Errors.Select(x => x.Description);
        var errorMessages = "\n-> " + string.Join("\n->", errors);
        _logger.LogError(
            "The following errors occurred while creating a user profile:{errorMessages}",
            errorMessages
        );
        return null;
    }

    public async Task<UserProfile?> GetUserProfileByIdOrEmail(string idOrEmail)
        => await _userManager.FindByIdAsync(idOrEmail) ?? await _userManager.FindByEmailAsync(idOrEmail.ToLower());


    public async Task<UserProfileVm?> GetUserProfileVmByIdOrEmail(string idOrEmail)
    {
        var userProfile = await GetUserProfileByIdOrEmail(idOrEmail);
        return userProfile is null
            ? null
            : new UserProfileVm
            {
                Id = userProfile.Id,
                FirstName = userProfile.FirstName,
                Surname = userProfile.Surname,
                Email = userProfile.Email ?? string.Empty,
                AccessLevel = userProfile.AccessLevel
            };
    }
}