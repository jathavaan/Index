namespace Index.Application.Features.Assignment.Query.GetAssignmentById;

public class GetAssignmentByIdQuery(int id) : Request<Response<AssignmentVm>>
{
    public int Id { get; set; } = id;
}