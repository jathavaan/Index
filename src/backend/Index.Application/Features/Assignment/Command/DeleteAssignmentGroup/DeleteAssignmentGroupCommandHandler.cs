namespace Index.Application.Features.Assignment.Command.DeleteAssignmentGroup;

public class DeleteAssignmentGroupCommandHandler(
    IAssignmentGroupSerivce assignmentGroupSerivce
) : IRequestHandler<DeleteAssignmentGroupCommand, Response<bool>>
{
    public async Task<Response<bool>> Handle(DeleteAssignmentGroupCommand request, CancellationToken cancellationToken)
    {
        var assignmentGroup = await assignmentGroupSerivce.GetAssignmentGroupById(request.Id);
        if (assignmentGroup is null)
            return new Response<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find assignment group with the id {request.Id}"
            };

        return new Response<bool>
        {
            Result = await assignmentGroupSerivce.DeleteAssignmentGroup(assignmentGroup)
        };
    }
}