namespace Index.Application.Features.Assignment.Command.EditAssignmentStartDate;

public class EditAssignmentStartDateCommand(int id, DateTime startDate) : Command<CommandResponse<AssignmentVm>>
{
    public int Id { get; set; } = id;
    public DateTime StartDate { get; set; } = startDate;
}