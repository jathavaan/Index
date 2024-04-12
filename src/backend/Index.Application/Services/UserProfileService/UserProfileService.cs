using Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;
using Microsoft.EntityFrameworkCore;

namespace Index.Application.Services.UserProfileService;

public class UserProfileService : IUserProfileService
{
    private readonly IndexDbContext _indexDbContext;

    public UserProfileService(IndexDbContext indexDbContext)
        => _indexDbContext = indexDbContext;

    public async Task<UserProfileVM> CreateUserProfile(CreateUserProfileCommandDto dto)
    {
        var userProfile = new UserProfile
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = dto.FirstName,
            Surname = dto.Surname,
            Email = dto.Email.ToLower(),
            Password = BCrypt.Net.BCrypt.EnhancedHashPassword(dto.Password),
            AccessLevel = (UserProfileAccessLevel)dto.AccessLevel
        };

        _indexDbContext.UserProfiles.Add(userProfile);
        await _indexDbContext.SaveChangesAsync();

        return new UserProfileVM
        {
            FirstName = userProfile.FirstName,
            Surname = userProfile.Surname,
            Email = userProfile.Email,
            AccessLevel = userProfile.AccessLevel
        };
    }

    public async Task<UserProfileVM?> GetUserProfileByIdOrEmail(string idOrEmail)
        => await _indexDbContext.UserProfiles
            .Where(x => x.Id == idOrEmail || x.Email == idOrEmail)
            .Select(x => new UserProfileVM
            {
                Email = x.Email,
                FirstName = x.FirstName,
                Surname = x.Surname,
                AccessLevel = x.AccessLevel
            })
            .FirstOrDefaultAsync();

    public async Task<bool> CheckUserCredentials(string email, string password)
    {
        var userProfile = await _indexDbContext.UserProfiles
            .Where(x => string.Equals(email, x.Email, StringComparison.OrdinalIgnoreCase))
            .FirstOrDefaultAsync();

        return userProfile is not null && BCrypt.Net.BCrypt.EnhancedVerify(password, userProfile.Password);
    }
}