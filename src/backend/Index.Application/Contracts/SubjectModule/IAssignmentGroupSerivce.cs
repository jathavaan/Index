namespace Index.Application.Contracts.SubjectModule;

public interface IAssignmentGroupSerivce
{
    public Task<AssignmentGroup?> GetAssignmentGroupById(int id);
    public Task<List<AssignmentGroup>> GetAssignmentGroupsByUserProfile(UserProfile userProfile);

    public Task<bool> CreateAssignmentGroup(Subject subject, int totalAssignments, int assignmentsRequired,
        UserProfile userProfile);

    public Task<bool> UpdateAssignmentGroup(AssignmentGroup assignmentGroup, Subject? subjec, int? totalAssignments,
        int? assignmentsRequired);

    public Task<bool> DeleteAssignmentGroup(AssignmentGroup assignmentGroup);
}