using Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;
using Index.Application.ViewModels;
using Index.Domain.Entities.UserModule;
using Microsoft.EntityFrameworkCore;

namespace Index.Application.Services.UserProfileService;

public class UserProfileService : IUserProfileService
{
    private readonly IndexDbContext _context;

    public UserProfileService(IndexDbContext context)
        => _context = context;

    public async Task<UserProfileVm> CreateUserProfile(CreateUserProfileCommandDto dto)
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

        _context.UserProfiles.Add(userProfile);
        await _context.SaveChangesAsync();

        return new UserProfileVm
        {
            Id = userProfile.Id,
            FirstName = userProfile.FirstName,
            Surname = userProfile.Surname,
            Email = userProfile.Email,
            AccessLevel = userProfile.AccessLevel
        };
    }

    public async Task<UserProfileVm?> GetUserProfileByIdOrEmail(string idOrEmail)
        => await _context.UserProfiles
            .Where(x => x.Id == idOrEmail || x.Email == idOrEmail)
            .Select(x => new UserProfileVm
            {
                Id = x.Id,
                Email = x.Email,
                FirstName = x.FirstName,
                Surname = x.Surname,
                AccessLevel = x.AccessLevel
            })
            .FirstOrDefaultAsync();

    public async Task<bool> CheckUserCredentials(string email, string password)
    {
        var userProfile = await _context.UserProfiles
            .Where(x => string.Equals(email, x.Email, StringComparison.OrdinalIgnoreCase))
            .FirstOrDefaultAsync();

        return userProfile is not null && BCrypt.Net.BCrypt.EnhancedVerify(password, userProfile.Password);
    }
}