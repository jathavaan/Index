namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class ReportCardController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpGet("get/{reportCardId}")]
    [Produces("application/json", Type = typeof(double))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(GetReportCardById))]
    public async Task<ActionResult<ReportCardVm>> GetReportCardById(int reportCardId)
        => await SendRequest<ReportCardVm, GetReportCardByIdQuery>(new GetReportCardByIdQuery(reportCardId));

    [HttpGet("get/{reportCardId}/gpa")]
    [Produces("application/json", Type = typeof(double))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(GetReportCardGpa))]
    public async Task<ActionResult<double>> GetReportCardGpa(int reportCardId)
        => await SendRequest<double, GetReportCardGpaQuery>(new GetReportCardGpaQuery(reportCardId));

    [HttpPost("create")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateReportCard))]
    public async Task<ActionResult<bool>> CreateReportCard(string name, string userProfileId)
        => await SendCommand<bool, CreateReportCardCommand>(new CreateReportCardCommand(name, userProfileId));

    [HttpPost("AddSubjectToReportCard")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(AddSubjectToReportCard))]
    public async Task<ActionResult<bool>> AddSubjectToReportCard(string subjectCode, int reportCardId, int year,
        int semester, int grade = -2)
        => await SendCommand<bool, AddSubjectToReportCardCommand>(
            new AddSubjectToReportCardCommand(subjectCode, reportCardId, year, semester, grade));

    [HttpDelete("delete/{reportCardId}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(DeleteReportCard))]
    public async Task<ActionResult<bool>> DeleteReportCard(int reportCardId)
        => await SendCommand<bool, DeleteReportCardCommand>(new DeleteReportCardCommand(reportCardId));
}