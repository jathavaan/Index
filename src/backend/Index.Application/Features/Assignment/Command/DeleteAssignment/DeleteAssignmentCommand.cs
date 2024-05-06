namespace Index.Application.Features.Assignment.Command.DeleteAssignment;

public class DeleteAssignmentCommand(int id) : Command<CommandResponse<bool>>
{
    public int Id { get; set; } = id;
}