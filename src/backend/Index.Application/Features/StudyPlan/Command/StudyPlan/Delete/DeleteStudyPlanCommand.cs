namespace Index.Application.Features.StudyPlan.Command.StudyPlan.Delete;

public class DeleteStudyPlanCommand(int studyPlanId) : Command<CommandResponse<bool>>
{
    public int StudyPlanId { get; set; } = studyPlanId;
}