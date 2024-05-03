namespace Index.Application.Features.ReportCard.Command.CreateReportCard;

public class CreateReportCardCommand(string name, string userProfileId) : Command<CommandResponse<bool>>
{
    public string Name = name;
    public string UserProfileProfileId = userProfileId;
}