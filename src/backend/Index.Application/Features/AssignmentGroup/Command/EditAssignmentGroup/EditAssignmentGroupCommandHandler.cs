namespace Index.Application.Features.AssignmentGroup.Command.EditAssignmentGroup;

public class EditAssignmentGroupCommandHandler(
    IAssignmentGroupSerivce assignmentGroupSerivce
) : IRequestHandler<EditAssignmentGroupCommand, Response<bool>>
{
    public async Task<Response<bool>> Handle(EditAssignmentGroupCommand request, CancellationToken cancellationToken)
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