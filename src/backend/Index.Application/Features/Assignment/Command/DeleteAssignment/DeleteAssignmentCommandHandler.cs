namespace Index.Application.Features.Assignment.Command.DeleteAssignment;

public class DeleteAssignmentCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<DeleteAssignmentCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(DeleteAssignmentCommand request,
        CancellationToken cancellationToken)
    {
        var assignment = await assignmentService.GetAssignment(request.Id);
        if (assignment is null)
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find assignment with id {request.Id}"
            };

        var result = await assignmentService.DeleteAssignment(assignment);
        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}