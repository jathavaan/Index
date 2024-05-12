namespace Index.Application.Features.StudyPlan.Command.StudyPlanSubject.UpdateYear;

public class UpdateStudyPlanSubjectYearCommandHandler(
    IStudyPlanService studyPlanService,
    ISubjectService subjectService
) : IRequestHandler<UpdateStudyPlanSubjectYearCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(UpdateStudyPlanSubjectYearCommand request,
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

        var result = await studyPlanService.UpdateStudyPlanSubjectYear(studyPlan, subject, request.Year);
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