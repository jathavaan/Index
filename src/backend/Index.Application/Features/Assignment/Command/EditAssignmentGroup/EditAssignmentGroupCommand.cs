namespace Index.Application.Features.Assignment.Command.EditAssignmentGroup;

public class EditAssignmentGroupCommand(int id) : Command<CommandResponse<bool>>
{
    public int Id { get; set; } = id;
    public string? SubjectCode { get; set; }
    public int? TotalAssignments { get; set; }
    public int? AssignmentsRequired { get; set; }
}