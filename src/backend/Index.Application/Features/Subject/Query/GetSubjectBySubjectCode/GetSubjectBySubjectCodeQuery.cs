namespace Index.Application.Features.Subject.Query.GetSubjectBySubjectCode;

public class GetSubjectBySubjectCodeQuery(string subjectCode) : Request<Response<SubjectVm>>
{
    public string SubjectCode { get; set; } = subjectCode;
}