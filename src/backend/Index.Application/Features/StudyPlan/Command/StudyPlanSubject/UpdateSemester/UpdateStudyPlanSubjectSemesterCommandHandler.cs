namespace Index.Application.Features.StudyPlan.Command.StudyPlanSubject.UpdateSemester;

public class UpdateStudyPlanSubjectSemesterCommandHandler(
    ISubjectService subjectService,
    IStudyPlanService studyPlanService
) : IRequestHandler<UpdateStudyPlanSubjectSemesterCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(UpdateStudyPlanSubjectSemesterCommand request,
        CancellationToken cancellationToken)
    {
        var studyPlan = await studyPlanService.GetStudyPlan(request.StudyPlanId);
        if (studyPlan is null)
        {
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find study plan with id {request.StudyPlanId}"
            };
        }

        var subject = await subjectService.GetSubject(request.SubjectCode);
        if (subject is null)
        {
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find subject with subject code {request.SubjectCode}"
            };
        }

        var result = await studyPlanService.UpdateStudyPlanSubjectSemester(studyPlan, subject, request.Semester);
        if (result is null)
        {
            return new CommandResponse<bool>()
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error =
                    $"Could not find the subject with code {request.SubjectCode} in the study plan with id {request.StudyPlanId}"
            };
        }

        return new CommandResponse<bool>
        {
            Result = (bool)result
        };
    }
}