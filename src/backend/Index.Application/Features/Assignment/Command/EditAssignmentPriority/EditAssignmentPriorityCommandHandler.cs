namespace Index.Application.Features.Assignment.Command.EditAssignmentPriority;

public class EditAssignmentPriorityCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentPriorityCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentPriorityCommand request,
        CancellationToken cancellationToken)
    {
        var assignment = await assignmentService.GetAssignment(request.Id);
        if (assignment is null)
            return new CommandResponse<AssignmentVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Assignment with id {request.Id} not found."
            };

        var result = await assignmentService.UpdateAssignmentPriority(assignment, request.Priority);
        return new CommandResponse<AssignmentVm>
        {
            Result = result
        };
    }
}