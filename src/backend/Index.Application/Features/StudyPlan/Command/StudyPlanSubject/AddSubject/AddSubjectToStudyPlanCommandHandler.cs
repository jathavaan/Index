namespace Index.Application.Features.StudyPlan.Command.StudyPlanSubject.AddSubject;

public class AddSubjectToStudyPlanCommandHandler(
    ISubjectService subjectService,
    IStudyPlanService studyPlanService
) : IRequestHandler<AddSubjectToStudyPlanCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(AddSubjectToStudyPlanCommand request,
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

        var result = await studyPlanService.AddSubjectToStudyPlan(
            studyPlan,
            subject,
            request.Year,
            request.Semester
        );
        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}