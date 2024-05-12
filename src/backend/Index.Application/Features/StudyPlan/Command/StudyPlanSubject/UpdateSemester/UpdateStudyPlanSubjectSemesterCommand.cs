namespace Index.Application.Features.StudyPlan.Command.StudyPlanSubject.UpdateSemester;

public class UpdateStudyPlanSubjectSemesterCommand(
    int studyPlanId,
    string subjectCode,
    Semester semster
) : Command<CommandResponse<bool>>
{
    public int StudyPlanId { get; set; } = studyPlanId;
    public string SubjectCode { get; set; } = subjectCode;
    public Semester Semester { get; set; } = semster;
}