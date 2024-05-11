namespace Index.Infrastructure.Services.SubjectModule;

public class ReportCardService : IReportCardService
{
    private readonly IndexDbContext _context;

    public ReportCardService(IndexDbContext context)
        => _context = context;

    public async Task<bool> CreateReportCard(string name, string userProfileId)
    {
        var reportCard = new ReportCard
        {
            Name = name,
            DateCreated = DateTime.Now,
            UserProfileId = userProfileId
        };

        _context.ReportCards.Add(reportCard);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<ReportCard?> GetReportCard(int id)
    {
        return await _context.ReportCards
            .Where(x => x.Id == id)
            .Include(x => x.ReportCardSubjects)
            .ThenInclude(x => x.Subject)
            .FirstOrDefaultAsync();
    }

    public async Task<List<ReportCard>> GetUserProfileReportCards(UserProfile userProfile)
        => await _context.ReportCards
            .Where(x => x.UserProfileId == userProfile.Id)
            .OrderByDescending(x => x.DateCreated)
            .Include(x => x.ReportCardSubjects)
            .ThenInclude(x => x.Subject)
            .ToListAsync();

    public async Task<double> GetReportCardGpa(ReportCard reportCard)
        => await _context.ReportCards
            .Where(rc => rc.Id == reportCard.Id)
            .Include(rc => rc.ReportCardSubjects)
            .ThenInclude(rcs => rcs.Subject)
            .Select(
                rc => rc.ReportCardSubjects
                    .Where(rcs => (int)rcs.Grade > 0)
                    .Select(
                        rcs => new Tuple<Grade, double>(rcs.Grade, rcs.Subject.Credits)
                    )
                    .ToList()
            )
            .Select(x => CalculateReportCardGpa(x))
            .FirstOrDefaultAsync();

    public double GetReportCardTotalCredits(ReportCard reportCard)
        => reportCard.ReportCardSubjects
            .Select(rcs => rcs.Subject)
            .Select(s => s.Credits)
            .Sum();

    public async Task<bool> UpdateReportCardName(ReportCard reportCard, string name)
    {
        reportCard.Name = name;
        _context.ReportCards.Update(reportCard);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteReportCard(ReportCard reportCard)
    {
        _context.ReportCardSubjects.RemoveRange(reportCard.ReportCardSubjects);
        _context.ReportCards.Remove(reportCard);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> AddSubjectToReportCard(Subject subject, ReportCard reportCard, Grade grade, int year,
        Semester semester)
    {
        if (reportCard.ReportCardSubjects.Any(x => x.Subject.SubjectCode == subject.SubjectCode)) return false;

        ReportCardSubject reportCardSubject = new()
        {
            ReportCardId = reportCard.Id,
            SubjectCode = subject.SubjectCode,
            Year = year,
            Semester = semester,
            Grade = grade
        };

        _context.ReportCardSubjects.Add(reportCardSubject);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> RemoveSubjectFromReportCard(Subject subject, ReportCard reportCard)
    {
        var reportCardSubject = await _context.ReportCardSubjects
            .Where(x => x.ReportCardId == reportCard.Id && x.SubjectCode == subject.SubjectCode)
            .FirstOrDefaultAsync();

        if (reportCardSubject is null) return false;
        _context.ReportCardSubjects.Remove(reportCardSubject);
        await _context.SaveChangesAsync();
        return true;
    }

    private static double CalculateReportCardGpa(List<Tuple<Grade, double>> gradeAndCreditList)
    {
        if (gradeAndCreditList.Count == 0) return 0;
        return Math.Round(gradeAndCreditList.Sum(x => (int)x.Item1 * x.Item2) /
                          gradeAndCreditList.Sum(x => x.Item2), 2);
    }
}