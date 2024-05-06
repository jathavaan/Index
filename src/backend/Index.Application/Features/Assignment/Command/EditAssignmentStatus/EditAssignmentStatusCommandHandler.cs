namespace Index.Application.Features.Assignment.Command.EditAssignmentStatus;

public class EditAssignmentStatusCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentStatusCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentStatusCommand request,
        CancellationToken cancellationToken)
    {
        var result = await assignmentService.UpdateAssignmentStatus(request.Id, request.Status);
        if (result is null)
        {
            return new CommandResponse<AssignmentVm>()
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find assignment with id {request.Id}"
            };
        }

        return new CommandResponse<AssignmentVm>()
        {
            Result = result
        };
    }
}