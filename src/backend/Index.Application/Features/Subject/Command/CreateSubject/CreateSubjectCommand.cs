namespace Index.Application.Features.Subject.Command.CreateSubject;

public class CreateSubjectCommand(CreateSubjectCommandDto dto) : Command<CommandResponse<bool>>
{
    public CreateSubjectCommandDto Dto { get; set; } = dto;
}

public class CreateSubjectCommandDto
{
    public string SubjectCode { get; set; } = null!;
    public string Name { get; set; } = null!;
    public double Credit { get; set; }
}