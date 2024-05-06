namespace Index.Application.Features.Assignment.Command.DeleteAssignmentGroup;

public class DeleteAssignmentGroupCommand(int id) : Command<CommandResponse<bool>>
{
    public int Id { get; set; } = id;
}