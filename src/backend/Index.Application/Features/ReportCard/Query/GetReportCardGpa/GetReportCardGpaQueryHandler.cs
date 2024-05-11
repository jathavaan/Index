using Index.Application.Contracts.SubjectModule;

namespace Index.Application.Features.ReportCard.Query.GetReportCardGpa;

public class GetReportCardGpaQueryHandler(IReportCardService reportCardService)
    : IRequestHandler<GetReportCardGpaQuery, Response<double>>
{
    public async Task<Response<double>> Handle(GetReportCardGpaQuery request, CancellationToken cancellationToken)
        => new()
        {
            Result = await reportCardService.GetReportCardGpa(request.ReportCardId)
        };
}