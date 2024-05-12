namespace Index.Application.Features.StudyPlan.Command.StudyPlan.Delete;

public class DeleteStudyPlanCommandHandler(
    IStudyPlanService studyPlanService
) : IRequestHandler<DeleteStudyPlanCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(DeleteStudyPlanCommand request, CancellationToken cancellationToken)
    {
        var studyPlan = await studyPlanService.GetStudyPlan(request.StudyPlanId);
        if (studyPlan is null)
        {
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find studyplan with id {request.StudyPlanId}"
            };
        }

        var result = await studyPlanService.DeleteStudyPlan(studyPlan);
        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}