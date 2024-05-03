namespace Index.Application.Features.ReportCard.Command.CreateReportCard;

public class CreateReportCardCommandHandler(IReportCardService reportCardService)
    : IRequestHandler<CreateReportCardCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(CreateReportCardCommand request,
        CancellationToken cancellationToken)
        => new() { Result = await reportCardService.CreateReportCard(request.Name, request.UserProfileProfileId) };
}