using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.Assignment.Command.EditAssignmentGroup;

public class EditAssignmentGroupCommandHandler(
    IAssignmentGroupSerivce assignmentGroupSerivce
) : IRequestHandler<EditAssignmentGroupCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(EditAssignmentGroupCommand request,
        CancellationToken cancellationToken)
        => new()
        {
            Result = await assignmentGroupSerivce.UpdateAssignmentGroup(
                request.Id,
                request.SubjectCode,
                request.TotalAssignments,
                request.AssignmentsRequired
            )
        };
}