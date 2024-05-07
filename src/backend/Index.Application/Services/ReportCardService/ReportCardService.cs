﻿namespace Index.Application.Services.ReportCardService;

public class ReportCardService : IReportCardService
{
    private readonly IndexDbContext _context;
    private readonly ISubjectService _subjectService;

    public ReportCardService(IndexDbContext context, ISubjectService subjectService)
    {
        _context = context;
        _subjectService = subjectService;
    }

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
        => await _context.ReportCards
            .Where(x => x.Id == id)
            .Include(x => x.ReportCardSubjects)
            .ThenInclude(x => x.Subject)
            .FirstOrDefaultAsync();

    public async Task<List<ReportCard>> GetReportCardsByUserId(string id)
        => await _context.ReportCards
            .Where(x => x.UserProfileId == id)
            .OrderByDescending(x => x.DateCreated)
            .Include(x => x.ReportCardSubjects)
            .ThenInclude(x => x.Subject)
            .ToListAsync();

    public async Task<double> GetReportCardGpa(int id)
        => await _context.ReportCards
            .Where(rc => rc.Id == id)
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

    public async Task<double> GetReportCardTotalCredits(int id)
    {
        var reportCard = await _context.ReportCards
            .Where(rc => rc.Id == id)
            .Include(rc => rc.ReportCardSubjects)
            .ThenInclude(rcs => rcs.Subject)
            .FirstOrDefaultAsync();

        if (reportCard is null) throw new Exception($"Could not find a report card with id {id}");

        return reportCard.ReportCardSubjects
            .Select(rcs => rcs.Subject)
            .Select(s => s.Credits)
            .Sum();
    }


    public async Task<bool> UpdateReportCardName(int id, string name)
    {
        var reportCard = await GetReportCard(id);
        if (reportCard is null) throw new Exception($"Could not find a report card with id {id}");

        reportCard.Name = name;
        _context.ReportCards.Update(reportCard);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteReportCard(int id)
    {
        var reportCard = await GetReportCard(id);
        if (reportCard is null) throw new Exception($"Could not find a report card with id {id}");

        _context.ReportCardSubjects.RemoveRange(reportCard.ReportCardSubjects);
        _context.ReportCards.Remove(reportCard);
        await _context.SaveChangesAsync();
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

        var subject = await _subjectService.GetSubject(subjectCode) ??
                      throw new Exception($"Could not find a subject with the id {subjectCode}");

        if (reportCard.ReportCardSubjects.Any(x => x.Subject.SubjectCode == subject.SubjectCode))
        {
            throw new Exception(
                $"{subject.SubjectCode} {subject.Name} has already been added to the report card with id {reportCard.Id}");
        }

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

    public async Task<bool> RemoveSubjectFromReportCard(string subjectCode, int reportCardId)
    {
        var reportCardSubject = await _context.ReportCardSubjects
            .Where(x => x.ReportCardId == reportCardId && x.SubjectCode == subjectCode)
            .FirstOrDefaultAsync() ?? throw new Exception($"Subject has not been added to the report card");

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