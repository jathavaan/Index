using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.Assignment.Command.EditAssignmentPriority;

public class EditAssignmentPriorityCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentPriorityCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentPriorityCommand request,
        CancellationToken cancellationToken)
    {
        var result = await assignmentService.UpdateAssignmentPriority(request.Id, request.Priority);
        if (result is null)
        {
            return new CommandResponse<AssignmentVm>()
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find a assignment with the id {request.Id}"
            };
        }

        return new CommandResponse<AssignmentVm>()
        {
            Result = result
        };
    }
}