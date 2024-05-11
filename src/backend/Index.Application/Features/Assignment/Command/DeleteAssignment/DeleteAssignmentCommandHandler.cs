using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.Assignment.Command.DeleteAssignment;

public class DeleteAssignmentCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<DeleteAssignmentCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(DeleteAssignmentCommand request,
        CancellationToken cancellationToken)
    {
        var isAssignmentDeleted = await assignmentService.DeleteAssignment(request.Id);
        return isAssignmentDeleted switch
        {
            true => new CommandResponse<bool> { Result = true },
            false => new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound, Error = $"Could not find assignment with id {request.Id}"
            }
        };
    }
}