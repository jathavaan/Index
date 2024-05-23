namespace Index.Api.Swagger.ModelSamples;

public class AssignmentVmExample : IExamplesProvider<AssignmentVm>
{
    public AssignmentVm GetExamples()
        => new()
        {
            Id = 1,
            Name = "Assignment 1",
            Priority = AssignmentPriority.High,
            Status = AssignmentStatus.InProgress,
            StartDate = null,
            DueDate = DateTime.Now.AddDays(7)
        };
}