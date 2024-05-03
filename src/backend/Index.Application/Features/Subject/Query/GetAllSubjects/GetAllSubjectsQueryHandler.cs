namespace Index.Application.Features.Subject.Query.GetAllSubjects;

public class GetAllSubjectsQueryHandler(ISubjectService subjectService)
    : IRequestHandler<GetAllSubjectsQuery, Response<List<SubjectVm>>>
{
    public async Task<Response<List<SubjectVm>>> Handle(GetAllSubjectsQuery request,
        CancellationToken cancellationToken)
    {
        var subjects = await subjectService.GetAllSubjects();
        var result = subjects.Select(x => new SubjectVm()
            {
                SubjectCode = x.SubjectCode,
                SubjectName = x.Name,
                Credit = x.Credit
            })
            .ToList();

        if (result.Count == 0)
        {
            return new Response<List<SubjectVm>>()
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = "Could not find any subjects"
            };
        }

        return new Response<List<SubjectVm>>()
        {
            Result = result
        };
    }
}