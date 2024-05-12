namespace Index.Application.Features.StudyPlan.Query.GetStudyPlanById;

public class GetStudyPlanByIdQuery(int id) : Request<Response<StudyPlanVm>>
{
    public int Id { get; set; } = id;
}