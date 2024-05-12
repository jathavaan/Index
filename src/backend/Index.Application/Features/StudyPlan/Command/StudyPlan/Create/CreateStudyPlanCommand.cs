namespace Index.Application.Features.StudyPlan.Command.StudyPlan.Create;

public class CreateStudyPlanCommand(string name, string userProfileId) : Command<CommandResponse<bool>>
{
    public string Name { get; set; } = name;
    public string UserProfileId { get; set; } = userProfileId;
}