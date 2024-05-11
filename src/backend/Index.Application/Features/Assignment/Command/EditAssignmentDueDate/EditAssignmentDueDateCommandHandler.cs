namespace Index.Application.Features.Assignment.Command.EditAssignmentDueDate;

public class EditAssignmentDueDateCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentDueDateCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentDueDateCommand request,
        CancellationToken cancellationToken)
    {
        var assignment = await assignmentService.GetAssignment(request.Id);
        if (assignment is null)
            return new CommandResponse<AssignmentVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find assignment with id {request.Id}"
            };

        var result = await assignmentService.UpdateAssignmentDueDate(assignment, request.DueDate);
        return new CommandResponse<AssignmentVm>
        {
            Result = result
        };
    }
}