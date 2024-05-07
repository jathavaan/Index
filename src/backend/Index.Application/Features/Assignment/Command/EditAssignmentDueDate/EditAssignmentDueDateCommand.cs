namespace Index.Application.Features.Assignment.Command.EditAssignmentDueDate;

public class EditAssignmentDueDateCommand(int id, DateTime dueDate) : Command<CommandResponse<AssignmentVm>>
{
    public int Id { get; set; } = id;
    public DateTime DueDate { get; set; } = dueDate;
}