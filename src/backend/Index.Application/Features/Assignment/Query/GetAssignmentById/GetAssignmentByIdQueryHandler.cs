using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.Assignment.Query.GetAssignmentById;

public class GetAssignmentByIdQueryHandler(
    IAssignmentService assignmentService
) : IRequestHandler<GetAssignmentByIdQuery, Response<AssignmentVm>>
{
    public async Task<Response<AssignmentVm>> Handle(GetAssignmentByIdQuery request,
        CancellationToken cancellationToken)
    {
        var assignment = await assignmentService.GetAssignment(request.Id);
        return assignment is null
            ? new Response<AssignmentVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find any assignments with id {request.Id}"
            }
            : new Response<AssignmentVm>
            {
                Result = new AssignmentVm
                {
                    Id = assignment.Id,
                    Name = assignment.Name,
                    Priority = assignment.Priority,
                    StartDate = assignment.StartDate,
                    DueDate = assignment.DueDate
                }
            };
    }
}