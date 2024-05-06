namespace Index.Application.Features.Assignment.Command.CreateAssignmentGroup;

public class CreateAssignmentGroupCommand(
    string subjectCode,
    int totalAssignments,
    int requiredAssignments,
    string userProfileId
) : Command<CommandResponse<bool>>
{
    public string SubjectCode { get; set; } = subjectCode;
    public int TotalAssignments { get; set; } = totalAssignments;
    public int RequiredAssignments { get; set; } = requiredAssignments;
    public string UserProfileId { get; set; } = userProfileId;
}