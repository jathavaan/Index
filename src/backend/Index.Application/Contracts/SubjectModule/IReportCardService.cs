namespace Index.Application.Contracts.SubjectModule;

public interface IReportCardService
{
    public Task<bool> CreateReportCard(string name, string userProfileId);
    public Task<ReportCard?> GetReportCard(int id);
    public Task<List<ReportCard>> GetUserProfileReportCards(UserProfile userProfile);
    public Task<double> GetReportCardGpa(ReportCard reportCard);
    public double GetReportCardTotalCredits(ReportCard reportCard);
    public Task<bool> UpdateReportCardName(ReportCard reportCard, string name);
    public Task<bool> DeleteReportCard(ReportCard reportCard);

    public Task<bool> AddSubjectToReportCard(Subject subject, ReportCard reportCard, Grade grade, int year,
        Semester semester);

    public Task<bool> RemoveSubjectFromReportCard(Subject subject, ReportCard reportCard);
}