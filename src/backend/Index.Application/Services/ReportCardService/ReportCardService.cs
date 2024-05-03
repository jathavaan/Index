namespace Index.Application.Services.ReportCardService;

public class ReportCardService(IndexDbContext indexDbContext, ISubjectService subjectService) : IReportCardService
{
    public async Task<bool> CreateReportCard(string name, string userProfileId)
    {
        var reportCard = new ReportCard
        {
            Name = name,
            DateCreated = DateTime.Now,
            UserProfileId = userProfileId
        };

        indexDbContext.ReportCards.Add(reportCard);
        await indexDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<ReportCard?> GetReportCard(int id)
        => await indexDbContext.ReportCards
            .Where(x => x.Id == id)
            .Include(x => x.ReportCardSubjects)
            .ThenInclude(x => x.Subject)
            .FirstOrDefaultAsync();

    public async Task<List<ReportCard>> GetReportCardsByUserId(string id)
        => await indexDbContext.ReportCards
            .Where(x => x.UserProfileId == id)
            .OrderByDescending(x => x.DateCreated)
            .Include(x => x.ReportCardSubjects)
            .ThenInclude(x => x.Subject)
            .ToListAsync();

    public async Task<double> GetReportCardGpa(int id)
        => await indexDbContext.ReportCards
            .Where(rc => rc.Id == id)
            .Include(rc => rc.ReportCardSubjects)
            .ThenInclude(rcs => rcs.Subject)
            .Select(
                rc => rc.ReportCardSubjects
                    .Where(rcs => rcs.Grade != null && (int)rcs.Grade > 0)
                    .Select(
                        rcs => new Tuple<Grade, double>((Grade)rcs.Grade!, rcs.Subject.Credit)
                    )
                    .ToList()
            )
            .Select(x => CalculateReportCardGpa(x))
            .FirstOrDefaultAsync();

    public async Task<double> GetReportCardTotalCredits(int id)
    {
        var reportCard = await indexDbContext.ReportCards
            .Where(rc => rc.Id == id)
            .Include(rc => rc.ReportCardSubjects)
            .ThenInclude(rcs => rcs.Subject)
            .FirstOrDefaultAsync();

        if (reportCard is null) throw new Exception($"Could not find a report card with id {id}");

        return reportCard.ReportCardSubjects
            .Select(rcs => rcs.Subject)
            .Select(s => s.Credit)
            .Sum();
    }


    public async Task<bool> UpdateReportCardName(int id, string name)
    {
        var reportCard = await GetReportCard(id);
        if (reportCard is null) throw new Exception($"Could not find a report card with id {id}");

        reportCard.Name = name;
        indexDbContext.ReportCards.Update(reportCard);
        await indexDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteReportCard(int id)
    {
        var reportCard = await GetReportCard(id);
        if (reportCard is null) throw new Exception($"Could not find a report card with id {id}");

        indexDbContext.ReportCardSubjects.RemoveRange(reportCard.ReportCardSubjects);
        indexDbContext.ReportCards.Remove(reportCard);
        await indexDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> AddSubjectToReportCard(string subjectCode, int reportCardId, Grade grade, int year,
        Semester semester)
    {
        var reportCard = await GetReportCard(reportCardId) ??
                         throw new Exception($"Could not find a report card with id {reportCardId}");

        if (reportCard.ReportCardSubjects.Any(x => x.Subject.SubjectCode == subjectCode))
        {
            return false;
        }

        var subject = await subjectService.GetSubject(null, subjectCode) ??
                      throw new Exception($"Could not find a subject with the id {subjectCode}");

        if (reportCard.ReportCardSubjects.Any(x => x.Subject.Id == subject.Id))
        {
            throw new Exception(
                $"{subject.SubjectCode} {subject.Name} has already been added to the report card with id {reportCard.Id}");
        }

        ReportCardSubject reportCardSubject = new()
        {
            ReportCardId = reportCard.Id,
            SubjectId = subject.Id,
            Year = year,
            Semester = semester,
            Grade = grade
        };

        indexDbContext.ReportCardSubjects.Add(reportCardSubject);
        await indexDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> RemoveSubjectFromReportCard(int subjectId, int reportCardId)
    {
        var reportCardSubject = await indexDbContext.ReportCardSubjects
            .Where(x => x.ReportCardId == reportCardId && x.SubjectId == subjectId)
            .FirstOrDefaultAsync() ?? throw new Exception($"Subject has not been added to the report card");

        indexDbContext.ReportCardSubjects.Remove(reportCardSubject);
        await indexDbContext.SaveChangesAsync();
        return true;
    }

    private static double CalculateReportCardGpa(List<Tuple<Grade, double>> gradeAndCreditList)
    {
        if (gradeAndCreditList.Count == 0) return 0;
        return Math.Round(gradeAndCreditList.Sum(x => (int)x.Item1 * x.Item2) /
                          gradeAndCreditList.Sum(x => x.Item2), 2);
    }
}