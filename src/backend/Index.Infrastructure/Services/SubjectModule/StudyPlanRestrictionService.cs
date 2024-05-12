namespace Index.Infrastructure.Services.SubjectModule;

public class StudyPlanRestrictionService : IStudyPlanRestrictionService
{
    private readonly IndexDbContext _context;

    public StudyPlanRestrictionService(IndexDbContext context)
        => _context = context;

    public async Task<bool> CreateStudyPlanRestriction(StudyPlan studyPlan, SubjectType subjectType,
        double requiredCredits, int year, Semester semester)
    {
        var studyPlanRestriction = new StudyPlanRestriction
        {
            SubjectType = subjectType,
            RequiredCredits = requiredCredits,
            Year = year,
            Semester = semester,
            StudyPlanId = studyPlan.Id
        };

        _context.StudyPlanRestrictions.Add(studyPlanRestriction);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<StudyPlanRestriction?> GetStudyPlanRestriction(int id)
        => await _context.StudyPlanRestrictions.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<bool> UpdateSubjectType(StudyPlanRestriction studyPlanRestriction, SubjectType subjectType)
    {
        if (studyPlanRestriction.SubjectType == subjectType) return false;
        studyPlanRestriction.SubjectType = subjectType;
        _context.StudyPlanRestrictions.Update(studyPlanRestriction);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateRequiredCredits(StudyPlanRestriction studyPlanRestriction, double requiredCredits)
    {
        if (Math.Abs(studyPlanRestriction.RequiredCredits - requiredCredits) < 1e-5) return false;
        studyPlanRestriction.RequiredCredits = requiredCredits;
        _context.StudyPlanRestrictions.Update(studyPlanRestriction);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateYear(StudyPlanRestriction studyPlanRestriction, int year)
    {
        if (studyPlanRestriction.Year == year) return false;
        studyPlanRestriction.Year = year;
        _context.StudyPlanRestrictions.Update(studyPlanRestriction);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateSemester(StudyPlanRestriction studyPlanRestriction, Semester semester)
    {
        if (studyPlanRestriction.Semester == semester) return false;
        studyPlanRestriction.Semester = semester;
        _context.StudyPlanRestrictions.Update(studyPlanRestriction);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteStudyPlanRestriction(StudyPlanRestriction studyPlanRestriction)
    {
        _context.StudyPlanRestrictions.Remove(studyPlanRestriction);
        await _context.SaveChangesAsync();
        return true;
    }
}