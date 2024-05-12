namespace Index.Application.Features.StudyPlan.Command.StudyPlan.UpdateName;

public class UpdateStudyPlanNameCommandHandler(
    IStudyPlanService studyPlanService
) : IRequestHandler<UpdateStudyPlanNameCommand, CommandResponse<StudyPlanVm>>
{
    public async Task<CommandResponse<StudyPlanVm>> Handle(UpdateStudyPlanNameCommand request,
        CancellationToken cancellationToken)
    {
        var studyPlan = await studyPlanService.GetStudyPlan(request.StudyPlanId);
        if (studyPlan is null)
        {
            return new CommandResponse<StudyPlanVm>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find study plan with id {request.StudyPlanId}"
            };
        }

        studyPlan = await studyPlanService.UpdateStudyPlanName(studyPlan, request.Name);
        var result = new StudyPlanVm
        {
            Id = studyPlan.Id,
            Name = studyPlan.Name,
            DateCreated = studyPlan.DateCreated,
            Subjects = studyPlan.StudyPlanSubjects
                .Select(x => new StudyPlanSubjectVm
                {
                    SubjectCode = x.Subject.SubjectCode,
                    SubjectName = x.Subject.Name,
                    Credits = x.Subject.Credits,
                    Year = x.Year,
                    Semester = x.Semester
                })
                .OrderByDescending(x => x.Year)
                .ThenByDescending(x => x.Semester)
                .ToList()
        };

        return new CommandResponse<StudyPlanVm>
        {
            Result = result
        };
    }
}