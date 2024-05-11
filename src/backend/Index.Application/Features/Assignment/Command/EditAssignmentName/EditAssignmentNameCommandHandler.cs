using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.Assignment.Command.EditAssignmentName;

public class EditAssignmentNameCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<EditAssignmentNameCommand, CommandResponse<AssignmentVm>>
{
    public async Task<CommandResponse<AssignmentVm>> Handle(EditAssignmentNameCommand request,
        CancellationToken cancellationToken)
    {
        var result = await assignmentService.UpdateAssignmentName(request.Id, request.Name);
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