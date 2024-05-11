namespace Index.Application.Features.ReportCard.Command.AddSubjectToReportCard;

public class AddSubjectToReportCardCommandHandler(
    IReportCardService reportcardService,
    ISubjectService subjectService
)
    : IRequestHandler<AddSubjectToReportCardCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(AddSubjectToReportCardCommand request,
        CancellationToken cancellationToken)
    {
        var subject = await subjectService.GetSubject(request.SubjectCode);
        if (subject is null)
        {
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Subject with subject code {request.SubjectCode} found"
            };
        }

        var reportCard = await reportcardService.GetReportCard(request.ReportCardId);
        if (reportCard is null)
        {
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Report card with id {request.ReportCardId} not found"
            };
        }

        var result = await reportcardService.AddSubjectToReportCard(
            subject,
            reportCard,
            request.Grade,
            request.Year,
            request.Semester
        );

        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}