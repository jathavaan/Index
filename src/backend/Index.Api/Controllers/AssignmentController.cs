namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class AssignmentController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpGet("Group/Get/{assignmentGroupId:int}")]
    [Produces("application/json", Type = typeof(AssignmentGroupVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(GetAssignmentGroupByIdQuery))]
    public async Task<ActionResult<AssignmentGroupVm>> GetAssignmentGroupById(int assignmentGroupId)
        => await SendRequest<AssignmentGroupVm, GetAssignmentGroupByIdQuery>(
            new GetAssignmentGroupByIdQuery(assignmentGroupId));

    [HttpPost("Group/Create/{subjectCode}/{userProfileId}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateAssignmentGroup))]
    public async Task<ActionResult<bool>> CreateAssignmentGroup(string subjectCode, string userProfileId,
        int totalAssignments = 0, int requiredAssignments = 0)
        => await SendCommand<bool, CreateAssignmentGroupCommand>(
            new CreateAssignmentGroupCommand(subjectCode, totalAssignments, requiredAssignments, userProfileId));

    [HttpPatch("Group/Edit/{assignmentGroupId:int}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditAssignmentGroupCommand))]
    public async Task<ActionResult<bool>> EditAssignmentGroup(int assignmentGroupId)
        => await SendCommand<bool, EditAssignmentGroupCommand>(new EditAssignmentGroupCommand(assignmentGroupId));

    [HttpDelete("Group/Delete/{assignmentGroupId:int}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(DeleteAssignmentGroup))]
    public async Task<ActionResult<bool>> DeleteAssignmentGroup(int assignmentGroupId)
        => await SendCommand<bool, DeleteAssignmentGroupCommand>(new DeleteAssignmentGroupCommand(assignmentGroupId));
}