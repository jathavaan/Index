namespace Index.Application.Features.Assignment.Command.EditAssignmentPriority;

public class EditAssignmentPriorityCommand(
    int id,
    AssignmentPriority priority
) : Command<CommandResponse<AssignmentVm>>
{
    public int Id { get; set; } = id;
    public AssignmentPriority Priority { get; set; } = priority;
}