namespace Index.Application.Features.Assignment.Command.EditAssignmentStatus;

public class EditAssignmentStatusCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentStatusCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentStatusCommand request,
        CancellationToken cancellationToken)
    {
        var assignment = await assignmentService.GetAssignment(request.Id);
        if (assignment is null)
            return new CommandResponse<AssignmentVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Assignment with id {request.Id} not found"
            };

        var result = await assignmentService.UpdateAssignmentStatus(assignment, request.Status);
        return new CommandResponse<AssignmentVm>
        {
            Result = result
        };
    }
}