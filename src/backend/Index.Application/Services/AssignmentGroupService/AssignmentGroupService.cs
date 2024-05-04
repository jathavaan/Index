namespace Index.Application.Services.AssignmentGroupService;

public class AssignmentGroupService(
    IndexDbContext indexDbContext,
    ISubjectService subjectService,
    IUserProfileService userProfileService
) : IAssignmentGroupSerivce
{
    public async Task<bool> CreateAssignmentGroup(string subjectCode, int totalAssignments,
        int assignmentsRequired, string userProfileId)
    {
        var subject = await subjectService.GetSubject(subjectCode);
        var userProfile = await userProfileService.GetUserProfileByIdOrEmail(userProfileId);

        if (subject is null) return false;
        if (userProfile is null) return false;

        var assignmentGroup = new AssignmentGroup
        {
            SubjectCode = subject.SubjectCode,
            TotalAssignments = totalAssignments,
            AssignmentsRequired = assignmentsRequired,
            UserProfileId = userProfile.Id
        };

        indexDbContext.Add(assignmentGroup);
        await indexDbContext.SaveChangesAsync();

        return true;
    }
}