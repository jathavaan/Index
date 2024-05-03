namespace Index.Application.Features.Subject.Command.DeleteSubject;

public class DeleteSubjectCommand(string subjectCode) : Command<CommandResponse<bool>>
{
    public string SubjectCode { get; set; } = subjectCode;
}