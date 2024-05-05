namespace Index.Application.Features.AssignmentGroup.Command.EditAssignmentGroup;

public class EditAssignmentGroupCommand(int id) : Command<CommandResponse<bool>>
{
    public int Id { get; set; } = id;
    public string? SubjectCode { get; set; }
    public int? TotalAssignments { get; set; }
    public int? AssignmentsRequired { get; set; }
}