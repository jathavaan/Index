namespace Index.Application.Features.Assignment.Command.CreateAssignment;

public class CreateAssignmentCommand(CreateAssignmentDto dto) : Command<CommandResponse<bool>>
{
    public CreateAssignmentDto Dto { get; set; } = dto;
}