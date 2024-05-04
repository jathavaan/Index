namespace Index.Application.Features.AssignmentGroup.Command.CreateAssignmentGroup;

public class CreateAssignmentGroupCommandHandler(IAssignmentGroupSerivce assignmentGroupSerivce)
    : IRequestHandler<CreateAssignmentGroupCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(CreateAssignmentGroupCommand request,
        CancellationToken cancellationToken)
        => new()
        {
            Result = await assignmentGroupSerivce.CreateAssignmentGroup(
                request.SubjectCode,
                request.TotalAssignments,
                request.RequiredAssignments,
                request.UserProfileId
            )
        };
}