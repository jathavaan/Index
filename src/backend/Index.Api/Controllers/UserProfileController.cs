namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class UserProfileController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpPost]
    [Produces("application/json", Type = typeof(UserProfileVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateUserProfile))]
    public async Task<ActionResult<UserProfileVm>> CreateUserProfile(CreateUserProfileCommandDto dto)
        => await SendCommand<UserProfileVm, CreateUserProfileCommand>(new CreateUserProfileCommand(dto));
}