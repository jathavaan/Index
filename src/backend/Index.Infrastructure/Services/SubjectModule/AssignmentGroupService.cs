namespace Index.Infrastructure.Services.SubjectModule;

public class AssignmentGroupService : IAssignmentGroupSerivce
{
    private readonly IndexDbContext _context;
    private readonly ILogger<AssignmentGroupService> _logger;

    public AssignmentGroupService(ILogger<AssignmentGroupService> logger, IndexDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<AssignmentGroup?> GetAssignmentGroupById(int id)
    {
        return await _context.AssignmentGroups
            .Where(x => x.Id == id)
            .Include(x => x.Subject)
            .Include(x => x.Assignments)
            .FirstOrDefaultAsync();
    }


    public async Task<List<AssignmentGroup>> GetAssignmentGroupsByUserProfile(UserProfile userProfile)
    {
        return await _context.AssignmentGroups
            .Where(x => x.UserProfileId == userProfile.Id)
            .ToListAsync();
    }

    public async Task<bool> CreateAssignmentGroup(Subject subject, int totalAssignments,
        int assignmentsRequired, UserProfile userProfile)
    {
        var assignmentGroups = await GetAssignmentGroupsByUserProfile(userProfile);
        if (assignmentGroups.Select(ag => ag.SubjectCode).Any(sc => sc == subject.SubjectCode))
        {
            _logger.LogInformation(
                "Subject {subject.SubjectCode} has already been added to the assignment groups",
                subject.SubjectCode
            );
            return false;
        }

        var assignmentGroup = new AssignmentGroup
        {
            SubjectCode = subject.SubjectCode,
            TotalAssignments = totalAssignments,
            AssignmentsRequired = assignmentsRequired,
            UserProfileId = userProfile.Id
        };

        _context.AssignmentGroups.Add(assignmentGroup);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> UpdateAssignmentGroup(AssignmentGroup assignmentGroup, Subject? subject,
        int? totalAssignments,
        int? assignmentsRequired)
    {
        if (subject is not null) assignmentGroup.SubjectCode = subject.SubjectCode;
        if (totalAssignments is not null && assignmentsRequired is not null)
        {
            if (totalAssignments < assignmentsRequired)
            {
                _logger.LogError("Total assignments cannot be less than assignments required");
                return false;
            }

            assignmentGroup.TotalAssignments = totalAssignments.Value;
            assignmentGroup.AssignmentsRequired = assignmentsRequired.Value;
        }
        else if (totalAssignments is not null)
        {
            if (totalAssignments < assignmentGroup.AssignmentsRequired)
            {
                _logger.LogError("Total assignments cannot be less than assignments required");
                return false;
            }

            assignmentGroup.TotalAssignments = totalAssignments.Value;
        }
        else if (assignmentsRequired is not null)
        {
            if (assignmentGroup.TotalAssignments < assignmentsRequired)
            {
                _logger.LogError("Required assignments cannot be greater than total assignments");
                return false;
            }

            assignmentGroup.AssignmentsRequired = assignmentsRequired.Value;
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAssignmentGroup(AssignmentGroup assignmentGroup)
    {
        _context.AssignmentGroups.Remove(assignmentGroup);
        await _context.SaveChangesAsync();
        return true;
    }
}