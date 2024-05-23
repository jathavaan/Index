namespace Index.Api.Swagger.ModelSamples;

public class AssignmentGroupVmExample : IExamplesProvider<AssignmentGroupVm>
{
    public AssignmentGroupVm GetExamples()
        => new()
        {
            Id = 12,
            SubjectCode = "TMA4240",
            SubjectName = "Statistics",
            TotalAssignments = 12,
            AssignmentsRequired = 8,
            AssignmentsSubmitted = 4,
            Assignments =
            [
                new AssignmentVm
                {
                    Id = 1,
                    Name = "Assignment 1",
                    Priority = AssignmentPriority.High,
                    Status = AssignmentStatus.Completed,
                    StartDate = new DateTime(2021, 10, 1),
                    DueDate = new DateTime(2021, 10, 15)
                },
                new AssignmentVm
                {
                    Id = 2,
                    Name = "Assignment 2",
                    Priority = AssignmentPriority.Medium,
                    Status = AssignmentStatus.InProgress,
                    StartDate = new DateTime(2021, 10, 16),
                    DueDate = new DateTime(2021, 10, 30)
                },
                new AssignmentVm
                {
                    Id = 3,
                    Name = "Assignment 3",
                    Priority = AssignmentPriority.Low,
                    Status = AssignmentStatus.NotStarted,
                    StartDate = new DateTime(2021, 11, 1),
                    DueDate = new DateTime(2021, 11, 15)
                }
            ]
        };
}