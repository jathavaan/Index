namespace Index.Application.Features.ReportCard.Command.DeleteReportCard;

public class DeleteReportCardCommandHandler(IReportCardService reportCardService)
    : IRequestHandler<DeleteReportCardCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(DeleteReportCardCommand request,
        CancellationToken cancellationToken)
    {
        var reportCard = await reportCardService.GetReportCard(request.ReportCardId);
        if (reportCard is null)
        {
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Report card with id {request.ReportCardId} not found"
            };
        }

        var result = await reportCardService.DeleteReportCard(reportCard);
        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}