using Index.Application.Contracts.SubjectModule.Dtos;

namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class AssignmentController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpGet("Get/{assignmentId:int}")]
    [Produces("application/json", Type = typeof(AssignmentVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(GetAssignmentGroupByIdQuery))]
    public async Task<ActionResult<AssignmentVm>> GetAssignmentById(int assignmentId)
        => await SendRequest<AssignmentVm, GetAssignmentByIdQuery>(new GetAssignmentByIdQuery(assignmentId));

    [HttpPost("Create")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateAssignment))]
    public async Task<ActionResult<bool>> CreateAssignment(CreateAssignmentDto dto)
        => await SendCommand<bool, CreateAssignmentCommand>(new CreateAssignmentCommand(dto));

    [HttpPatch("Edit/Name/{assignmentId:int}/{name}")]
    [Produces("application/json", Type = typeof(AssignmentVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditAssignmentName))]
    public async Task<ActionResult<AssignmentVm>> EditAssignmentName(int assignmentId, string name)
        => await SendCommand<AssignmentVm, EditAssignmentNameCommand>(
            new EditAssignmentNameCommand(assignmentId, name));

    [HttpPatch("Edit/Priority/{assignmentId:int}/{priority}")]
    [Produces("application/json", Type = typeof(AssignmentVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditAssignmentPriority))]
    public async Task<ActionResult<AssignmentVm>> EditAssignmentPriority(int assignmentId, AssignmentPriority priority)
        => await SendCommand<AssignmentVm, EditAssignmentPriorityCommand>(
            new EditAssignmentPriorityCommand(assignmentId, priority));

    [HttpPatch("Edit/Status/{assignmentId:int}/{status}")]
    [Produces("application/json", Type = typeof(AssignmentVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditAssignmentStatus))]
    public async Task<ActionResult<AssignmentVm>> EditAssignmentStatus(int assignmentId, AssignmentStatus status)
        => await SendCommand<AssignmentVm, EditAssignmentStatusCommand>(
            new EditAssignmentStatusCommand(assignmentId, status));

    [HttpPatch("Edit/StartDate/{assignmentId:int}/{startDate}")]
    [Produces("application/json", Type = typeof(AssignmentVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditAssignmentStartDate))]
    public async Task<ActionResult<AssignmentVm>> EditAssignmentStartDate(int assignmentId, DateTime startDate)
        => await SendCommand<AssignmentVm, EditAssignmentStartDateCommand>(
            new EditAssignmentStartDateCommand(assignmentId, startDate));

    [HttpPatch("Edit/DueDate/{assignmentId:int}/{dueDate}")]
    [Produces("application/json", Type = typeof(AssignmentVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditAssignmentDueDate))]
    public async Task<ActionResult<AssignmentVm>> EditAssignmentDueDate(int assignmentId, DateTime dueDate)
        => await SendCommand<AssignmentVm, EditAssignmentDueDateCommand>(
            new EditAssignmentDueDateCommand(assignmentId, dueDate));

    [HttpDelete("Delete/{assignmentId:int}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(DeleteAssignment))]
    public async Task<ActionResult<bool>> DeleteAssignment(int assignmentId)
        => await SendCommand<bool, DeleteAssignmentCommand>(new DeleteAssignmentCommand(assignmentId));

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
        => await SendCommand<bool, DeleteAssignmentGroupCommand>(
            new DeleteAssignmentGroupCommand(assignmentGroupId));
}