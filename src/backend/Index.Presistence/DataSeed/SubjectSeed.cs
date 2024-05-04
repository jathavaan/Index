namespace Index.Presistence.DataSeed;

public static class SubjectSeed
{
    internal static void LookupData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Subject>().HasData(
            new Subject
            {
                SubjectCode = "EXPH0300",
                Name = "Examen philosophicum for Science and Technology",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "HMS0002",
                Name = "Health, Safety and Environment (HSE) course for 1st year students",
                Credits = 0
            },
            new Subject
            {
                SubjectCode = "IT2805",
                Name = "Web Technologies",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4231",
                Name = "Applied Geomatics",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4236",
                Name = "Theoretical Geomatics",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4240",
                Name = "Geographic Information Handling 1, Basic Course",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4250",
                Name = "Geographic Information Handling 2, Basic Course",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4251",
                Name = "Programming in Geomatics",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4256",
                Name = "3D Digital Modelling",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TFY4115",
                Name = "Physics",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TEP4100",
                Name = "Fluid Mechanics",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TEP4225",
                Name = "Energy and Environment",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4100",
                Name = "Object-Oriented Programming",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4110",
                Name = "Information Technology, Introduction",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4120",
                Name = "Algorithms and Data Structures",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4140",
                Name = "Software Engineering",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4145",
                Name = "Data Modelling, Databases, and Database Management Systems",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4173",
                Name = "Machine Learning",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TKT4116",
                Name = "Mechanics 1",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TKT4122",
                Name = "Mechanics 2",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4100",
                Name = "Calculus 1",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4105",
                Name = "Calculus 2",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4115",
                Name = "Mathematics 3 - Linear Algebra",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4130",
                Name = "Mathematics 4N - Differential Equations and Fourier Analysis",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4140",
                Name = "Discrete Mathematics",
                Credits = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4240",
                Name = "Statistics",
                Credits = 7.5
            }
        );
    }
}