namespace Index.Application.Features.Assignment.Command.EditAssignmentStartDate;

public class EditAssignmentStartDateCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentStartDateCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentStartDateCommand request,
        CancellationToken cancellationToken)
    {
        var assignmentVm = await assignmentService.UpdateAssignmentStartDate(request.Id, request.StartDate);
        if (assignmentVm is null)
        {
            return new CommandResponse<AssignmentVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find assignment with id {request.Id}"
            };
        }

        return new CommandResponse<AssignmentVm>
        {
            Result = assignmentVm
        };
    }
}