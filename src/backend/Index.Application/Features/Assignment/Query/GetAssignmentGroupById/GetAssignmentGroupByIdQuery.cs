namespace Index.Application.Features.Assignment.Query.GetAssignmentGroupById;

public class GetAssignmentGroupByIdQuery(int id) : Request<Response<AssignmentGroupVm>>
{
    public int Id { get; set; } = id;
}