namespace Index.Api.Swagger.ModelSamples;

public class ReportCardVmExample : IExamplesProvider<ReportCardVm>
{
    public ReportCardVm GetExamples()
        => new()
        {
            ReportCardId = 25,
            Name = "Report Card 1",
            Subjects =
            [
                new SubjectWithGradeVm
                {
                    SubjectCode = "TDT4100",
                    SubjectName = "Object-Oriented Programming",
                    Year = 2020,
                    Semester = Semester.Spring,
                    Grade = Grade.B
                },
                new SubjectWithGradeVm()
                {
                    SubjectCode = "TDT4173",
                    SubjectName = "Machine learning",
                    Year = 2023,
                    Semester = Semester.Fall,
                    Grade = Grade.A
                },
            ],
            TotalCredits = 15.0,
            Gpa = 4.0
        };
}