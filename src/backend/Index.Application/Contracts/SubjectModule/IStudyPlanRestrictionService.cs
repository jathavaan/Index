namespace Index.Application.Contracts.SubjectModule;

public interface IStudyPlanRestrictionService
{
    public Task<bool> CreateStudyPlanRestriction(StudyPlan studyPlan, SubjectType subjectType, double requiredCredits,
        int year, Semester semester);

    public Task<StudyPlanRestriction?> GetStudyPlanRestriction(int id);
    public Task<bool> UpdateSubjectType(StudyPlanRestriction studyPlanRestriction, SubjectType subjectType);
    public Task<bool> UpdateRequiredCredits(StudyPlanRestriction studyPlanRestriction, double requiredCredits);
    public Task<bool> UpdateYear(StudyPlanRestriction studyPlanRestriction, int year);
    public Task<bool> UpdateSemester(StudyPlanRestriction studyPlanRestriction, Semester semester);
    public Task<bool> DeleteStudyPlanRestriction(StudyPlanRestriction studyPlanRestriction);
}