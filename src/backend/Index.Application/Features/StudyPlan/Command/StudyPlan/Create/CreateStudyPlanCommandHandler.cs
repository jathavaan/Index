namespace Index.Application.Features.StudyPlan.Command.StudyPlan.Create;

public class CreateStudyPlanCommandHandler(
    IStudyPlanService studyPlanService,
    IUserProfileService userProfileService
) : IRequestHandler<CreateStudyPlanCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(CreateStudyPlanCommand request, CancellationToken cancellationToken)
    {
        var userProfile = await userProfileService.GetUserProfileByIdOrEmail(request.UserProfileId);
        if (userProfile is null)
        {
            return new CommandResponse<bool>()
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find userprofile with id {request.UserProfileId}"
            };
        }

        var result = await studyPlanService.CreateStudyPlan(request.Name, userProfile);
        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}