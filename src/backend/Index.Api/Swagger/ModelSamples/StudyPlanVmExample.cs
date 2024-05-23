namespace Index.Api.Swagger.ModelSamples;

public class StudyPlanVmExample : IExamplesProvider<StudyPlanVm>
{
    public StudyPlanVm GetExamples()
        => new()
        {
            Id = 5,
            Name = "Study Plan 1",
            DateCreated = DateTime.Now,
            Subjects =
            [
                new StudyPlanSubjectVm
                {
                    SubjectCode = "TDT4100",
                    SubjectName = "Object-Oriented Programming",
                    Credits = 7.5,
                    Year = 2020,
                    Semester = Semester.Spring
                },
                new StudyPlanSubjectVm
                {
                    SubjectCode = "TDT4173",
                    SubjectName = "Machine learning",
                    Credits = 7.5,
                    Year = 2023,
                    Semester = Semester.Fall
                },
            ]
        };
}