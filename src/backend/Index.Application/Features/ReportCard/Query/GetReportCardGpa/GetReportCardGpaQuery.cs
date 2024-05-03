namespace Index.Application.Features.ReportCard.Query.GetReportCardGpa;

public class GetReportCardGpaQuery(int reportCardId) : Request<Response<double>>
{
    public int ReportCardId = reportCardId;
}