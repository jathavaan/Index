namespace Index.Application.Features.Assignment.Command.EditAssignmentGroup;

public class EditAssignmentGroupCommandHandler(
    IAssignmentGroupSerivce assignmentGroupSerivce,
    ISubjectService subjectService
) : IRequestHandler<EditAssignmentGroupCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(EditAssignmentGroupCommand request,
        CancellationToken cancellationToken)
    {
        var assignmentGroup = await assignmentGroupSerivce.GetAssignmentGroupById(request.Id);
        if (assignmentGroup == null)
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = "Assignment group not found"
            };

        var subject = request.SubjectCode is null ? null : await subjectService.GetSubject(request.SubjectCode!);
        return new CommandResponse<bool>
        {
            Result = await assignmentGroupSerivce.UpdateAssignmentGroup(
                assignmentGroup,
                subject,
                request.TotalAssignments,
                request.AssignmentsRequired
            )
        };
    }
}