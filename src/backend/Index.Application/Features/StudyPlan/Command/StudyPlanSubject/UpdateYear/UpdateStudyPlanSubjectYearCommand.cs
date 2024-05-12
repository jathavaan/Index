namespace Index.Application.Features.StudyPlan.Command.StudyPlanSubject.UpdateYear;

public class UpdateStudyPlanSubjectYearCommand(
    int studyPlanId,
    string subjectCode,
    int year
) : Command<CommandResponse<bool>>
{
    public int StudyPlanId { get; set; } = studyPlanId;
    public string SubjectCode { get; set; } = subjectCode;
    public int Year { get; set; } = year;
}