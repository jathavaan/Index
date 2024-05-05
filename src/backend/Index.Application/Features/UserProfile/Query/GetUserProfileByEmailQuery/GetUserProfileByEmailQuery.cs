namespace Index.Application.Features.UserProfile.Query.GetUserProfileByEmailQuery;

public class GetUserProfileByEmailQuery(string email) : Request<Response<UserProfileVm>>
{
    public string Email { get; set; } = email;
}