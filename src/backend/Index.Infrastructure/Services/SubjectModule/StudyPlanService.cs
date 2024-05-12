namespace Index.Infrastructure.Services.SubjectModule;

public class StudyPlanService : IStudyPlanService
{
    private readonly IndexDbContext _context;

    public StudyPlanService(IndexDbContext context)
        => _context = context;


    public async Task<bool> CreateStudyPlan(string name, UserProfile userProfile)
    {
        var studyPlan = new StudyPlan
        {
            Name = name,
            UserProfileId = userProfile.Id,
            DateCreated = DateTime.Now
        };

        _context.StudyPlans.Add(studyPlan);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<StudyPlan?> GetStudyPlan(int studyPlanId)
        => await _context.StudyPlans
            .Include(x => x.StudyPlanSubjects)
            .ThenInclude(x => x.Subject)
            .FirstOrDefaultAsync(x => x.Id == studyPlanId);

    public async Task<StudyPlan> UpdateStudyPlanName(StudyPlan studyPlan, string newName)
    {
        studyPlan.Name = newName;
        _context.StudyPlans.Update(studyPlan);
        await _context.SaveChangesAsync();
        return studyPlan;
    }

    public async Task<bool> DeleteStudyPlan(StudyPlan studyPlan)
    {
        _context.StudyPlans.Remove(studyPlan);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> AddSubjectToStudyPlan(StudyPlan studyPlan, Subject subject, int year, Semester semester)
    {
        var isSubjectAlreadyAdded = studyPlan.StudyPlanSubjects.Any(sps => sps.SubjectCode == subject.SubjectCode);
        if (isSubjectAlreadyAdded) return false;
        var studyPlanSubject = new StudyPlanSubject
        {
            StudyPlanId = studyPlan.Id,
            SubjectCode = subject.SubjectCode,
            Year = year,
            Semester = semester
        };

        _context.StudyPlanSubjects.Add(studyPlanSubject);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool?> UpdateStudyPlanSubjectYear(StudyPlan studyPlan, Subject subject, int year)
    {
        var studyPlanSubject = studyPlan.StudyPlanSubjects.FirstOrDefault(x => x.SubjectCode == subject.SubjectCode);
        if (studyPlanSubject is null) return null;
        if (studyPlanSubject.Year == year) return false;

        studyPlanSubject.Year = year;
        _context.StudyPlanSubjects.Update(studyPlanSubject);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool?> UpdateStudyPlanSubjectSemester(StudyPlan studyPlan, Subject subject, Semester semester)
    {
        var studyPlanSubject = studyPlan.StudyPlanSubjects.FirstOrDefault(x => x.SubjectCode == subject.SubjectCode);
        if (studyPlanSubject is null) return null;
        if (studyPlanSubject.Semester == semester) return false;

        studyPlanSubject.Semester = semester;
        _context.StudyPlanSubjects.Update(studyPlanSubject);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> RemoveSubjectFromStudyPlan(StudyPlan studyPlan, Subject subject)
    {
        var studyPlanSubject = studyPlan.StudyPlanSubjects
            .FirstOrDefault(sps => sps.SubjectCode == subject.SubjectCode);

        if (studyPlanSubject is null) return false;
        _context.StudyPlanSubjects.Remove(studyPlanSubject);
        await _context.SaveChangesAsync();
        return true;
    }
}