namespace Index.Application.Features.ReportCard.Command.AddSubjectToReportCard;

public class AddSubjectToReportCardCommand(
    string subjectCode,
    int reportCardId,
    int year,
    Semester semester,
    Grade grade
) : Command<CommandResponse<bool>>
{
    public int ReportCardId = reportCardId;
    public string SubjectCode = subjectCode;
    public int Year = year;
    public Semester Semester = semester;
    public Grade Grade = grade;
}