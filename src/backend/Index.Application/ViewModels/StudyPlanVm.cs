namespace Index.Application.ViewModels;

public class StudyPlanVm
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public List<StudyPlanSubjectVm> Subjects { get; set; } = [];
}

public class StudyPlanSubjectVm
{
    public string SubjectCode { get; set; } = null!;
    public string SubjectName { get; set; } = null!;
    public double Credits { get; set; }
    public int Year { get; set; }
    public Semester Semester { get; set; }
}