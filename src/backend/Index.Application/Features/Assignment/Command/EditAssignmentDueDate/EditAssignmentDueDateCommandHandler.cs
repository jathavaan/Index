using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.Assignment.Command.EditAssignmentDueDate;

public class EditAssignmentDueDateCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentDueDateCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentDueDateCommand request,
        CancellationToken cancellationToken)
    {
        var result = await assignmentService.UpdateAssignmentDueDate(request.Id, request.DueDate);
        if (result is null)
        {
            return new CommandResponse<AssignmentVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Assignment with id {request.Id} not found"
            };
        }

        return new CommandResponse<AssignmentVm>
        {
            Result = result
        };
    }
}