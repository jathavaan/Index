namespace Index.Application.Features.UserProfile.Query.GetUserProfileByEmailQuery;

public class GetUserProfileByEmailQueryHandler(
    IUserProfileService userProfileService
) : IRequestHandler<GetUserProfileByEmailQuery, Response<UserProfileVm>>
{
    public async Task<Response<UserProfileVm>> Handle(GetUserProfileByEmailQuery request,
        CancellationToken cancellationToken)
    {
        var userProfile = await userProfileService.GetUserProfileByIdOrEmail(request.Email);

        if (userProfile is null)
        {
            return new Response<UserProfileVm>()
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"User profile not found for the following email {request.Email}"
            };
        }

        return new Response<UserProfileVm>()
        {
            Result = new UserProfileVm
            {
                Id = userProfile.Id,
                FirstName = userProfile.FirstName,
                Surname = userProfile.Surname,
                Email = userProfile.Email,
                AccessLevel = userProfile.AccessLevel
            }
        };
    }
}