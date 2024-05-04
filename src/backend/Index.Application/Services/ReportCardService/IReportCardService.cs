namespace Index.Application.Services.ReportCardService;

public interface IReportCardService
{
    public Task<bool> CreateReportCard(string name, string userProfileId);
    public Task<ReportCard?> GetReportCard(int id);
    public Task<List<ReportCard>> GetReportCardsByUserId(string id);
    public Task<double> GetReportCardGpa(int id);
    public Task<double> GetReportCardTotalCredits(int id);
    public Task<bool> UpdateReportCardName(int id, string name);
    public Task<bool> DeleteReportCard(int id);
    public Task<bool> AddSubjectToReportCard(string subjectCode, int reportCardId, Grade? grade);
    public Task<bool> RemoveSubjectFromReportCard(string subjectCode, int reportCardId);
}