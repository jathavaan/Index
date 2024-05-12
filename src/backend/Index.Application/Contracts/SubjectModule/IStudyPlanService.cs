namespace Index.Application.Contracts.SubjectModule;

public interface IStudyPlanService
{
    public Task<bool> CreateStudyPlan(string name, UserProfile userProfile);
    public Task<StudyPlan?> GetStudyPlan(int studyPlanId);
    public Task<StudyPlan> UpdateStudyPlanName(StudyPlan studyPlan, string newName);
    public Task<bool> DeleteStudyPlan(StudyPlan studyPlan);
    public Task<bool> AddSubjectToStudyPlan(StudyPlan studyPlan, Subject subject, int year, Semester semester);
    public Task<bool?> UpdateStudyPlanSubjectYear(StudyPlan studyPlan, Subject subject, int year);
    public Task<bool?> UpdateStudyPlanSubjectSemester(StudyPlan studyPlan, Subject subject, Semester semester);
    public Task<bool> RemoveSubjectFromStudyPlan(StudyPlan studyPlan, Subject subject);
}