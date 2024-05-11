using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.Assignment.Command.CreateAssignment;

public class CreateAssignmentCommandHandler(
    IAssignmentService assignmentService
) : IRequestHandler<CreateAssignmentCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(CreateAssignmentCommand request,
        CancellationToken cancellationToken)
        => new()
        {
            Result = await assignmentService.CreateAssignment(request.Dto)
        };
}