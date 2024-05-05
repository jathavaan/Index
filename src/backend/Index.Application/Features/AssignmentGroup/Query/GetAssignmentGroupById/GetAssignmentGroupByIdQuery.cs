namespace Index.Application.Features.AssignmentGroup.Query.GetAssignmentGroupById;

public class GetAssignmentGroupByIdQuery(int id) : Request<Response<AssignmentGroupVm>>
{
    public int Id { get; set; } = id;
}