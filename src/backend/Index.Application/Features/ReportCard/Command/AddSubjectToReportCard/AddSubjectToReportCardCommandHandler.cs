namespace Index.Application.Features.ReportCard.Command.AddSubjectToReportCard;

public class AddSubjectToReportCardCommandHandler(IReportCardService reportcardService)
    : IRequestHandler<AddSubjectToReportCardCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(AddSubjectToReportCardCommand request,
        CancellationToken cancellationToken)
        => new()
        {
            Result = await reportcardService.AddSubjectToReportCard(request.SubjectCode, request.ReportCardId,
                (Grade)request.Grade, request.Year, (Semester)request.Semester)
        };
}