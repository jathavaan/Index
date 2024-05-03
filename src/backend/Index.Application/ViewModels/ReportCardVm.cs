namespace Index.Application.ViewModels;

public class ReportCardVm
{
    public int ReportCardId { get; set; }
    public string Name { get; set; } = null!;
    public List<SubjectWithGradeVm> Subjects { get; set; } = [];
    public double TotalCredits { get; set; }
    public double Gpa { get; set; }
}

public class SubjectWithGradeVm
{
    public string SubjectCode { get; set; } = null!;
    public string SubjectName { get; set; } = null!;
    public int Year { get; set; }
    public Semester Semester { get; set; }
    public double Credit { get; set; }
    public Grade? Grade { get; set; }
}