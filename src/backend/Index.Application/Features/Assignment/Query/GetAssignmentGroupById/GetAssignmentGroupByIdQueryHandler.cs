namespace Index.Application.Features.Assignment.Query.GetAssignmentGroupById;

public class GetAssignmentGroupByIdQueryHandler(
    IAssignmentGroupSerivce assignmentGroupSerivce
) : IRequestHandler<GetAssignmentGroupByIdQuery, Response<AssignmentGroupVm>>
{
    public async Task<Response<AssignmentGroupVm>> Handle(GetAssignmentGroupByIdQuery request,
        CancellationToken cancellationToken)
    {
        var assignmentGroup = await assignmentGroupSerivce.GetAssignmentGroupById(request.Id);

        if (assignmentGroup is null)
        {
            return new Response<AssignmentGroupVm>()
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find assignment group with id {request.Id}"
            };
        }

        var result = new AssignmentGroupVm
        {
            Id = assignmentGroup.Id,
            SubjectCode = assignmentGroup.Subject.SubjectCode,
            SubjectName = assignmentGroup.Subject.Name,
            TotalAssignments = assignmentGroup.TotalAssignments,
            AssignmentsRequired = assignmentGroup.AssignmentsRequired,
            AssignmentsCompleted = assignmentGroup.Assignments
                .Count(x => x.Status == AssignmentStatus.Completed),
            Assignments = assignmentGroup.Assignments.Select(a => new AssignmentVm
                {
                    Id = a.Id,
                    Name = a.Name,
                    Priority = a.Priority,
                    Status = a.Status,
                    StartDate = a.StartDate,
                    DueDate = a.DueDate
                })
                .ToList()
        };

        return new Response<AssignmentGroupVm>()
        {
            Result = result
        };
    }
}