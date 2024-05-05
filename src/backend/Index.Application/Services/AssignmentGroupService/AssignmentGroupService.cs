namespace Index.Application.Services.AssignmentGroupService;

public class AssignmentGroupService(
    ILogger<AssignmentGroupService> logger,
    IndexDbContext indexDbContext,
    ISubjectService subjectService,
    IUserProfileService userProfileService
) : IAssignmentGroupSerivce
{
    public async Task<AssignmentGroup?> GetAssignmentGroupById(int id)
        => await indexDbContext.AssignmentGroups
            .Where(x => x.Id == id)
            .Include(x => x.Subject)
            .Include(x => x.Assignments)
            .FirstOrDefaultAsync();


    public async Task<List<AssignmentGroup>> GetAssignmentGroupsByUserProfileId(string userProfileId)
        => await indexDbContext.AssignmentGroups
            .Where(x => x.UserProfileId == userProfileId)
            .ToListAsync();

    public async Task<bool> CreateAssignmentGroup(string subjectCode, int totalAssignments,
        int assignmentsRequired, string userProfileId)
    {
        var subject = await subjectService.GetSubject(subjectCode);
        var userProfile = await userProfileService.GetUserProfileByIdOrEmail(userProfileId);
        var assignmentGroups = await GetAssignmentGroupsByUserProfileId(userProfileId);

        if (subject is null)
        {
            logger.LogInformation("Subject {subjectCode} does not exist", subjectCode);
            return false;
        }

        if (userProfile is null)
        {
            logger.LogInformation("User profile {userProfileId} does not exist", userProfileId);
            return false;
        }

        if (assignmentGroups.Select(ag => ag.SubjectCode).Any(sc => sc == subjectCode))
        {
            logger.LogInformation(
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

        indexDbContext.AssignmentGroups.Add(assignmentGroup);
        await indexDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> UpdateAssignmentGroup(int id, string? subjectCode, int? totalAssignments,
        int? assignmentsRequired)
    {
        var assignmentGroup = await GetAssignmentGroupById(id);
        if (assignmentGroup is null)
        {
            logger.LogInformation("Assignment group {id} does not exist", id);
            return false;
        }

        if (subjectCode is not null)
        {
            var subject = await subjectService.GetSubject(subjectCode);
            if (subject is null)
            {
                logger.LogInformation("Subject {subjectCode} does not exist", subjectCode);
                return false;
            }

            assignmentGroup.SubjectCode = subjectCode;
        }

        switch (totalAssignments)
        {
            case >= 0:
                assignmentGroup.TotalAssignments = totalAssignments.Value;
                break;
            case < 0:
                logger.LogInformation("Total assignments {totalAssignments} is less than 0", totalAssignments);
                return false;
        }

        switch (assignmentsRequired)
        {
            case >= 0 when assignmentsRequired <= assignmentGroup.TotalAssignments:
                assignmentGroup.AssignmentsRequired = assignmentsRequired.Value;
                break;
            case >= 0 when totalAssignments < 0:
                logger.LogInformation("Assignments required {assignmentsRequired} is less than 0", assignmentsRequired);
                return false;
            case >= 0:
                logger.LogInformation(
                    "Assignments required {assignmentsRequired} is greater than total assignments {totalAssignments}",
                    assignmentsRequired, assignmentGroup.TotalAssignments
                );
                return false;
        }

        await indexDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAssignmentGroup(int id)
    {
        var assignmentGroup = await GetAssignmentGroupById(id);

        switch (assignmentGroup)
        {
            case not null:
                indexDbContext.AssignmentGroups.Remove(assignmentGroup);
                await indexDbContext.SaveChangesAsync();
                return true;
            default:
                return false;
        }
    }
}