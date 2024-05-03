namespace Index.Application.Features.Subject.Command.EditSubject;

public class EditSubjectCommand(string subjectCode, string? name, double? credits) : Command<CommandResponse<bool>>
{
    public string SubjectCode { get; set; } = subjectCode;
    public string? NewName { get; set; } = name;
    public double? Credits { get; set; } = credits;
}