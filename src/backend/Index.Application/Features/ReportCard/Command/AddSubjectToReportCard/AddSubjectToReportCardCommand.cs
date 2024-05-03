namespace Index.Application.Features.ReportCard.Command.AddSubjectToReportCard;

public class AddSubjectToReportCardCommand(string subjectCode, int reportCardId, int grade) : Command<CommandResponse<bool>>
{
    public string SubjectCode = subjectCode;
    public int ReportCardId = reportCardId;
    public int Grade = grade;
}