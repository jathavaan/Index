namespace Index.Application.Features.Assignment.Command.CreateAssignmentGroup;

public class CreateAssignmentGroupCommandHandler(
    IAssignmentGroupSerivce assignmentGroupSerivce,
    IUserProfileService userProfileService,
    ISubjectService subjectService
)
    : IRequestHandler<CreateAssignmentGroupCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(CreateAssignmentGroupCommand request,
        CancellationToken cancellationToken)
    {
        var userProfile = await userProfileService.GetUserProfileByIdOrEmail(request.UserProfileId);
        if (userProfile == null)
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = "User profile not found"
            };

        var subject = await subjectService.GetSubject(request.SubjectCode);
        if (subject == null)
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = "Subject not found"
            };

        return new CommandResponse<bool>
        {
            Result = await assignmentGroupSerivce.CreateAssignmentGroup(
                subject,
                request.TotalAssignments,
                request.RequiredAssignments,
                userProfile
            )
        };
    }
}