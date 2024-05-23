namespace Index.Api.Swagger.ModelSamples;

public class UserProfileVmExample : IExamplesProvider<UserProfileVm>
{
    public UserProfileVm GetExamples()
        => new()
        {
            Id = new Guid().ToString(),
            FirstName = "John",
            Surname = "Doe",
            Email = "john.doe@email.com",
            AccessLevel = UserProfileAccessLevel.StandardUser
        };
}