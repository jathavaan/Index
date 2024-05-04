namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class AssignmentController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpPost("assignmentGroup/create/{subjectCode}/{userProfileId}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateAssignmentGroup))]
    public async Task<ActionResult<bool>> CreateAssignmentGroup(string subjectCode, string userProfileId,
        int totalAssignments = 0, int requiredAssignments = 0)
        => await SendCommand<bool, CreateAssignmentGroupCommand>(
            new CreateAssignmentGroupCommand(subjectCode, totalAssignments, requiredAssignments, userProfileId));
}