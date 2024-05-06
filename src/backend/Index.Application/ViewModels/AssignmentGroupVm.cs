namespace Index.Application.ViewModels;

public class AssignmentGroupVm
{
    public int Id { get; set; }
    public string SubjectCode { get; set; } = null!;
    public string SubjectName { get; set; } = null!;
    public int TotalAssignments { get; set; }
    public int AssignmentsRequired { get; set; }
    public int AssignmentsSubmitted { get; set; }
    public List<AssignmentVm> Assignments { get; set; } = [];
}