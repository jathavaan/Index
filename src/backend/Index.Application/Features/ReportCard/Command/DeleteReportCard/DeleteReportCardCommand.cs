namespace Index.Application.Features.ReportCard.Command.DeleteReportCard;

public class DeleteReportCardCommand(int reportCardId) : Command<CommandResponse<bool>>
{
    public int ReportCardId { get; set; } = reportCardId;
}