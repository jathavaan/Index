namespace Index.Application.Features.StudyPlan.Query.GetStudyPlanById;

public class GetStudyPlanByIdQueryHandler(
    IStudyPlanService studyPlanService
) : IRequestHandler<GetStudyPlanByIdQuery, Response<StudyPlanVm>>
{
    public async Task<Response<StudyPlanVm>> Handle(GetStudyPlanByIdQuery request, CancellationToken cancellationToken)
    {
        var studyPlan = await studyPlanService.GetStudyPlan(request.Id);
        if (studyPlan is null)
        {
            return new Response<StudyPlanVm>()
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Study plan with id {request.Id} not found"
            };
        }

        var result = new StudyPlanVm()
        {
            Id = studyPlan.Id,
            Name = studyPlan.Name,
            DateCreated = studyPlan.DateCreated,
            Subjects = studyPlan.StudyPlanSubjects
                .Select(s => new StudyPlanSubjectVm
                {
                    SubjectCode = s.Subject.SubjectCode,
                    SubjectName = s.Subject.Name,
                    Credits = s.Subject.Credits,
                    Year = s.Year,
                    Semester = s.Semester
                })
                .OrderByDescending(x => x.Year)
                .ThenByDescending(x => x.Semester)
                .ToList()
        };

        return new Response<StudyPlanVm>()
        {
            Result = result
        };
    }
}