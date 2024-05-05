namespace Index.Application.Features.Subject.Query.GetSubjectBySubjectCode;

public class GetSubjectBySubjectCodeQueryHandler(
    ISubjectService subjectService
) : IRequestHandler<GetSubjectBySubjectCodeQuery, Response<SubjectVm>>
{
    public async Task<Response<SubjectVm>> Handle(GetSubjectBySubjectCodeQuery request,
        CancellationToken cancellationToken)
    {
        var subject = await subjectService.GetSubject(request.SubjectCode);
        if (subject is null)
        {
            return new Response<SubjectVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find subject with subject code {request.SubjectCode}"
            };
        }

        return new Response<SubjectVm>
        {
            Result = new SubjectVm
            {
                SubjectCode = subject.SubjectCode,
                SubjectName = subject.Name,
                Credit = subject.Credits
            }
        };
    }
}