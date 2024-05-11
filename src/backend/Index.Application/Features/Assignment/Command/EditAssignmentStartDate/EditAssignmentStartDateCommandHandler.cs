namespace Index.Application.Features.Assignment.Command.EditAssignmentStartDate;

public class EditAssignmentStartDateCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentStartDateCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentStartDateCommand request,
        CancellationToken cancellationToken)
    {
        var assignment = await assignmentService.GetAssignment(request.Id);
        if (assignment is null)
            return new CommandResponse<AssignmentVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Assignment with id {request.Id} not found"
            };

        var result = await assignmentService.UpdateAssignmentStartDate(assignment, request.StartDate);
        return new CommandResponse<AssignmentVm>
        {
            Result = result
        };
    }
}