namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class SubjectController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpGet("get/{subjectCode}")]
    [Produces("application/json", Type = typeof(SubjectVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(GetSubject))]
    public async Task<ActionResult<SubjectVm>> GetSubject(string subjectCode)
        => await SendRequest<SubjectVm, GetSubjectBySubjectCodeQuery>(new GetSubjectBySubjectCodeQuery(subjectCode));

    [HttpGet("get")]
    [Produces("application/json", Type = typeof(SubjectVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(GetAllSubjects))]
    public async Task<ActionResult<List<SubjectVm>>> GetAllSubjects()
        => await SendRequest<List<SubjectVm>, GetAllSubjectsQuery>(new GetAllSubjectsQuery());

    [HttpPost("create")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateSubject))]
    public async Task<ActionResult<bool>> CreateSubject(CreateSubjectCommandDto dto)
        => await SendCommand<bool, CreateSubjectCommand>(new CreateSubjectCommand(dto));


    [HttpPatch("edit/{subjectCode}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditSubject))]
    public async Task<ActionResult<bool>> EditSubject(string subjectCode, string? name, double? credits)
        => await SendCommand<bool, EditSubjectCommand>(new EditSubjectCommand(subjectCode, name, credits));

    [HttpDelete("delete/{subjectCode}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    public async Task<ActionResult<bool>> DeleteSubject(string subjectCode)
        => await SendCommand<bool, DeleteSubjectCommand>(new DeleteSubjectCommand(subjectCode));
}