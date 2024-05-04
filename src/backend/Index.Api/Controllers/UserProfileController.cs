namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class UserProfileController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpGet("GetByEmail/{email}")]
    [Produces("application/json")]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(GetUserProfileByEmail))]
    public async Task<ActionResult<UserProfileVm>> GetUserProfileByEmail(string email)
        => await SendRequest<UserProfileVm, GetUserProfileByEmailQuery>(new GetUserProfileByEmailQuery(email));

    [HttpPost]
    [Produces("application/json", Type = typeof(UserProfileVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateUserProfile))]
    public async Task<ActionResult<UserProfileVm>> CreateUserProfile(CreateUserProfileCommandDto dto)
        => await SendCommand<UserProfileVm, CreateUserProfileCommand>(new CreateUserProfileCommand(dto));
}