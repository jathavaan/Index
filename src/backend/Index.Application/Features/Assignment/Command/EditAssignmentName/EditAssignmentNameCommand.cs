namespace Index.Application.Features.Assignment.Command.EditAssignmentName;

public class EditAssignmentNameCommand(int id, string name) : Command<CommandResponse<AssignmentVm>>
{
    public int Id { get; } = id;
    public string Name { get; } = name;
}