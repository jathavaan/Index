namespace Index.Application.Features.ReportCard.Command.AddSubjectToReportCard;

public class AddSubjectToReportCardCommand(string subjectCode, int reportCardId, int year, int semester, int grade) : Command<CommandResponse<bool>>
{
    public string SubjectCode = subjectCode;
    public int ReportCardId = reportCardId;
    public int Year = year;
    public int Semester = semester;
    public int Grade = grade;
}