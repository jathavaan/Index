namespace Index.Application.Services.AssignmentGroupService;

public interface IAssignmentGroupSerivce
{
    public Task<bool> CreateAssignmentGroup(string subjectCode, int totalAssignments,
        int assignmentsRequired, string userProfileId);
}