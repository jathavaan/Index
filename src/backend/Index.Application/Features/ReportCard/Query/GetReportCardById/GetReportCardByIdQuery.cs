namespace Index.Application.Features.ReportCard.Query.GetReportCardById;

public class GetReportCardByIdQuery(int id) : Request<Response<ReportCardVm>>
{
    public int Id { get; set; } = id;
}