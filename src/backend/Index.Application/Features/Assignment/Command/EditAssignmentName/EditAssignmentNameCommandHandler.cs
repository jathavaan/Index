namespace Index.Application.Features.Assignment.Command.EditAssignmentName;

public class EditAssignmentNameCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentNameCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentNameCommand request,
        CancellationToken cancellationToken)
    {
        var assignment = await assignmentService.GetAssignment(request.Id);
        if (assignment is null)
            return new CommandResponse<AssignmentVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find assignment with id {request.Id}"
            };

        var result = await assignmentService.UpdateAssignmentName(assignment, request.Name);
        return new CommandResponse<AssignmentVm>
        {
            Result = result
        };
    }
}