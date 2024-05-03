namespace Index.Presistence.DataSeed;

public class SubjectSeed
{
    internal static void LookupData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Subject>().HasData(
            new Subject
            {
                Id = 1,
                SubjectCode = "EXPH0300",
                Name = "Examen philosophicum for Science and Technology",
                Credit = 7.5
            },
            new Subject
            {
                Id = 25,
                SubjectCode = "HMS0002",
                Name = "Health, Safety and Environment (HSE) course for 1st year students",
                Credit = 0
            },
            new Subject
            {
                Id = 2,
                SubjectCode = "IT2805",
                Name = "Web Technologies",
                Credit = 7.5
            },
            new Subject
            {
                Id = 3,
                SubjectCode = "TBA4231",
                Name = "Applied Geomatics",
                Credit = 7.5
            },
            new Subject
            {
                Id = 4,
                SubjectCode = "TBA4236",
                Name = "Theoretical Geomatics",
                Credit = 7.5
            },
            new Subject
            {
                Id = 5,
                SubjectCode = "TBA4240",
                Name = "Geographic Information Handling 1, Basic Course",
                Credit = 7.5
            },
            new Subject
            {
                Id = 6,
                SubjectCode = "TBA4250",
                Name = "Geographic Information Handling 2, Basic Course",
                Credit = 7.5
            },
            new Subject
            {
                Id = 7,
                SubjectCode = "TBA4251",
                Name = "Programming in Geomatics",
                Credit = 7.5
            },
            new Subject
            {
                Id = 8,
                SubjectCode = "TBA4256",
                Name = "3D Digital Modelling",
                Credit = 7.5
            },
            new Subject
            {
                Id = 9,
                SubjectCode = "TFY4115",
                Name = "Physics",
                Credit = 7.5
            },
            new Subject
            {
                Id = 10,
                SubjectCode = "TEP4100",
                Name = "Fluid Mechanics",
                Credit = 7.5
            },
            new Subject
            {
                Id = 11,
                SubjectCode = "TEP4225",
                Name = "Energy and Environment",
                Credit = 7.5
            },
            new Subject
            {
                Id = 12,
                SubjectCode = "TDT4100",
                Name = "Object-Oriented Programming",
                Credit = 7.5
            },
            new Subject
            {
                Id = 13,
                SubjectCode = "TDT4110",
                Name = "Information Technology, Introduction",
                Credit = 7.5
            },
            new Subject
            {
                Id = 14,
                SubjectCode = "TDT4120",
                Name = "Algorithms and Data Structures",
                Credit = 7.5
            },
            new Subject
            {
                Id = 15,
                SubjectCode = "TDT4140",
                Name = "Software Engineering",
                Credit = 7.5
            },
            new Subject
            {
                Id = 16,
                SubjectCode = "TDT4145",
                Name = "Data Modelling, Databases, and Database Management Systems",
                Credit = 7.5
            },
            new Subject
            {
                Id = 17,
                SubjectCode = "TDT4173",
                Name = "Machine Learning",
                Credit = 7.5
            },
            new Subject
            {
                Id = 18,
                SubjectCode = "TKT4116",
                Name = "Mechanics 1",
                Credit = 7.5
            },
            new Subject
            {
                Id = 19,
                SubjectCode = "TKT4122",
                Name = "Mechanics 2",
                Credit = 7.5
            },
            new Subject
            {
                Id = 20,
                SubjectCode = "TMA4100",
                Name = "Calculus 1",
                Credit = 7.5
            },
            new Subject
            {
                Id = 21,
                SubjectCode = "TMA4105",
                Name = "Calculus 2",
                Credit = 7.5
            },
            new Subject
            {
                Id = 22,
                SubjectCode = "TMA4115",
                Name = "Mathematics 3 - Linear Algebra",
                Credit = 7.5
            },
            new Subject
            {
                Id = 23,
                SubjectCode = "TMA4130",
                Name = "Mathematics 4N - Differential Equations and Fourier Analysis",
                Credit = 7.5
            },
            new Subject
            {
                Id = 24,
                SubjectCode = "TMA4140",
                Name = "Discrete Mathematics",
                Credit = 7.5
            }
        );
    }
}