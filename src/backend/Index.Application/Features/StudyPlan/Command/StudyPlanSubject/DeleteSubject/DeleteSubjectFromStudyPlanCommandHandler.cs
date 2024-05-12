namespace Index.Application.Features.StudyPlan.Command.StudyPlanSubject.DeleteSubject;

public class DeleteSubjectFromStudyPlanCommandHandler(
    ISubjectService subjectService,
    IStudyPlanService studyPlanService
) : IRequestHandler<DeleteSubjectFromStudyPlanCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(DeleteSubjectFromStudyPlanCommand request,
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

        var result = await studyPlanService.RemoveSubjectFromStudyPlan(studyPlan, subject);
        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}