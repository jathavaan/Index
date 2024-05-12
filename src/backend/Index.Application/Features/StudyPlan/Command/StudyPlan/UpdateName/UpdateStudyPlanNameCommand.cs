namespace Index.Application.Features.StudyPlan.Command.StudyPlan.UpdateName;

public class UpdateStudyPlanNameCommand(int studyPlanId, string name) : Command<CommandResponse<StudyPlanVm>>
{
    public int StudyPlanId { get; set; } = studyPlanId;
    public string Name { get; set; } = name;
}