namespace Index.Application.Services.AssignmentGroupService;

public interface IAssignmentGroupSerivce
{
    public Task<AssignmentGroup?> GetAssignmentGroupById(int id);
    public Task<List<AssignmentGroup>> GetAssignmentGroupsByUserProfileId(string userProfileId);

    public Task<bool> CreateAssignmentGroup(string subjectCode, int totalAssignments,
        int assignmentsRequired, string userProfileId);

    public Task<bool> UpdateAssignmentGroup(int id, string? subjectCode, int? totalAssignments,
        int? assignmentsRequired);

    public Task<bool> DeleteAssignmentGroup(int id);
}