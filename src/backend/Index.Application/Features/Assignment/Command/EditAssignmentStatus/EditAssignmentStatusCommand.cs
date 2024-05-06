namespace Index.Application.Features.Assignment.Command.EditAssignmentStatus;

public class EditAssignmentStatusCommand(int id, AssignmentStatus status) : Command<CommandResponse<AssignmentVm>>
{
    public int Id { get; set; } = id;
    public AssignmentStatus Status { get; set; } = status;
}