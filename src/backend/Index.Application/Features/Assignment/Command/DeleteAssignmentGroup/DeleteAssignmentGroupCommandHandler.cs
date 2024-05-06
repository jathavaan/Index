namespace Index.Application.Features.Assignment.Command.DeleteAssignmentGroup;

public class DeleteAssignmentGroupCommandHandler(
    IAssignmentGroupSerivce assignmentGroupSerivce
) : IRequestHandler<DeleteAssignmentGroupCommand, Response<bool>>
{
    public async Task<Response<bool>> Handle(DeleteAssignmentGroupCommand request, CancellationToken cancellationToken)
        => new()
        {
            Result = await assignmentGroupSerivce.DeleteAssignmentGroup(request.Id)
        };
}