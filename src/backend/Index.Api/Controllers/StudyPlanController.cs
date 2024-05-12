namespace Index.Api.Controllers;

[Route("api/[controller]")]
[ApiConventionType(typeof(SwaggerApiConvention))]
[ApiController]
public class StudyPlanController(IMediator mediator) : IndexControllerBase(mediator)
{
    [HttpGet("Get/{id:int}")]
    [Produces("application/json", Type = typeof(StudyPlanVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(GetStudyPlanById))]
    public async Task<ActionResult<StudyPlanVm>> GetStudyPlanById(int id)
        => await SendRequest<StudyPlanVm, GetStudyPlanByIdQuery>(new GetStudyPlanByIdQuery(id));

    [HttpPost("Create/{name}/{userProfileId}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(CreateStudyPlan))]
    public async Task<ActionResult<bool>> CreateStudyPlan(string name, string userProfileId)
        => await SendCommand<bool, CreateStudyPlanCommand>(new CreateStudyPlanCommand(name, userProfileId));

    [HttpPatch("{studyPlanId:int}/EditName/{newName}")]
    [Produces("application/json", Type = typeof(StudyPlanVm))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditStudyPlanName))]
    public async Task<ActionResult<StudyPlanVm>> EditStudyPlanName(int studyPlanId, string newName)
        => await SendCommand<StudyPlanVm, UpdateStudyPlanNameCommand>(
            new UpdateStudyPlanNameCommand(studyPlanId, newName));

    [HttpDelete("{studyPlanId:int}/Delete")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(DeleteStudyPlan))]
    public async Task<ActionResult<bool>> DeleteStudyPlan(int studyPlanId)
        => await SendCommand<bool, DeleteStudyPlanCommand>(new DeleteStudyPlanCommand(studyPlanId));

    [HttpPost("{studyPlanId:int}/AddSubject/{subjectCode}/{year:int}/{semester}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(AddSubjectToStudyPlan))]
    public async Task<ActionResult<bool>> AddSubjectToStudyPlan(int studyPlanId, string subjectCode, int year,
        Semester semester)
        => await SendCommand<bool, AddSubjectToStudyPlanCommand>(
            new AddSubjectToStudyPlanCommand(studyPlanId, subjectCode, year, semester));

    [HttpPatch("{studyPlanId:int}/Edit/{subjectCode}/Year/{year:int}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditSbujectYear))]
    public async Task<ActionResult<bool>> EditSbujectYear(int studyPlanId, string subjectCode, int year)
        => await SendCommand<bool, UpdateStudyPlanSubjectYearCommand>(
            new UpdateStudyPlanSubjectYearCommand(studyPlanId, subjectCode, year));

    [HttpPatch("{studyPlanId:int}/Edit/{subjectCode}/Semester/{semester}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(EditSbujectSemester))]
    public async Task<ActionResult<bool>> EditSbujectSemester(int studyPlanId, string subjectCode, Semester semester)
        => await SendCommand<bool, UpdateStudyPlanSubjectSemesterCommand>(
            new UpdateStudyPlanSubjectSemesterCommand(studyPlanId, subjectCode, semester));

    [HttpDelete("{studyPlanId:int}/Delete/{subjectCode}")]
    [Produces("application/json", Type = typeof(bool))]
    [ApiConventionMethod(typeof(SwaggerApiConvention), nameof(SwaggerApiConvention.StatusResponseTypes))]
    [ActionName(nameof(RemoveSubjectFromStudyPlan))]
    public async Task<ActionResult<bool>> RemoveSubjectFromStudyPlan(int studyPlanId, string subjectCode)
        => await SendCommand<bool, DeleteSubjectFromStudyPlanCommand>(
            new DeleteSubjectFromStudyPlanCommand(studyPlanId, subjectCode));
}