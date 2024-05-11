using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.ReportCard.Command.DeleteReportCard;

public class DeleteReportCardCommandHandler(IReportCardService reportCardService)
    : IRequestHandler<DeleteReportCardCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(DeleteReportCardCommand request, CancellationToken cancellationToken)
        => new()
        {
            Result = await reportCardService.DeleteReportCard(request.ReportCardId)
        };
}