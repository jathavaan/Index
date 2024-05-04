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
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "HMS0002",
                Name = "Health, Safety and Environment (HSE) course for 1st year students",
                Credit = 0
            },
            new Subject
            {
                SubjectCode = "IT2805",
                Name = "Web Technologies",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4231",
                Name = "Applied Geomatics",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4236",
                Name = "Theoretical Geomatics",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4240",
                Name = "Geographic Information Handling 1, Basic Course",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4250",
                Name = "Geographic Information Handling 2, Basic Course",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4251",
                Name = "Programming in Geomatics",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TBA4256",
                Name = "3D Digital Modelling",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TFY4115",
                Name = "Physics",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TEP4100",
                Name = "Fluid Mechanics",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TEP4225",
                Name = "Energy and Environment",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4100",
                Name = "Object-Oriented Programming",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4110",
                Name = "Information Technology, Introduction",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4120",
                Name = "Algorithms and Data Structures",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4140",
                Name = "Software Engineering",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4145",
                Name = "Data Modelling, Databases, and Database Management Systems",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TDT4173",
                Name = "Machine Learning",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TKT4116",
                Name = "Mechanics 1",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TKT4122",
                Name = "Mechanics 2",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4100",
                Name = "Calculus 1",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4105",
                Name = "Calculus 2",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4115",
                Name = "Mathematics 3 - Linear Algebra",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4130",
                Name = "Mathematics 4N - Differential Equations and Fourier Analysis",
                Credit = 7.5
            },
            new Subject
            {
                SubjectCode = "TMA4140",
                Name = "Discrete Mathematics",
                Credit = 7.5
            }
        );
    }
}