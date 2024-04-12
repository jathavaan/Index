using Index.Api.Base;

namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class UserProfileController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpPost]
    [Produces("application/json", Type = typeof(UserProfileVM))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateUserProfile))]
    public async Task<ActionResult<UserProfileVM>> CreateUserProfile(CreateUserProfileCommandDto dto)
        => await SendCommand<UserProfileVM, CreateUserProfileCommand>(new CreateUserProfileCommand(dto));
}