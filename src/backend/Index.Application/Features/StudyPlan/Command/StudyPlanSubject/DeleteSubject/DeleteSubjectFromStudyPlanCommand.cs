namespace Index.Application.Features.StudyPlan.Command.StudyPlanSubject.DeleteSubject;

public class DeleteSubjectFromStudyPlanCommand(int studyPlanId, string subjectCode) : Command<CommandResponse<bool>>
{
    public int StudyPlanId { get; set; } = studyPlanId;
    public string SubjectCode { get; set; } = subjectCode;
}