namespace Index.Application.Features.StudyPlan.Command.StudyPlanSubject.AddSubject;

public class AddSubjectToStudyPlanCommand(
    int studyPlanId,
    string subjectCode,
    int year,
    Semester semester
) : Command<CommandResponse<bool>>
{
    public int StudyPlanId { get; set; } = studyPlanId;
    public string SubjectCode { get; set; } = subjectCode;
    public int Year { get; set; } = year;
    public Semester Semester { get; set; } = semester;
}