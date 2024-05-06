namespace Index.Application.Services.AssignmentService;

public class AssignmentService(IndexDbContext indexDbContext) : IAssignmentService
{
    public async Task<Assignment?> GetAssignment(int id)
        => await indexDbContext.Assignments
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();

    public async Task<bool> CreateAssignment(CreateAssignmentDto dto)
    {
        var assignemnt = new Assignment
        {
            Name = dto.Name,
            Priority = dto.Priority,
            Status = dto.Status,
            StartDate = dto.StartDate,
            DueDate = dto.DueDate,
            AssignmentGroupId = dto.AssignmentGroupId
        };

        indexDbContext.Assignments.Add(assignemnt);
        await indexDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAssignment(int id)
    {
        var assignment = await GetAssignment(id);
        switch (assignment)
        {
            case not null:
                indexDbContext.Assignments.Remove(assignment);
                await indexDbContext.SaveChangesAsync();
                return true;
            case null:
                return false;
        }
    }

    public async Task<bool> RenameAssignment(int id, string name)
    {
        var assignment = await GetAssignment(id);
        switch (assignment)
        {
            case not null:
                assignment.Name = name;
                indexDbContext.Assignments.Update(assignment);
                await indexDbContext.SaveChangesAsync();
                return true;
            case null:
                return false;
        }
    }

    public async Task<bool> UpdateLastModifiedDate(int id)
    {
        var assignment = await GetAssignment(id);
        switch (assignment)
        {
            case not null:
                assignment.DateModified = DateTime.Now;
                indexDbContext.Assignments.Update(assignment);
                await indexDbContext.SaveChangesAsync();
                return true;
            case null:
                return false;
        }
    }

    public async Task<AssignmentVm?> UpdateAssignmentPriority(int id, AssignmentPriority priority)
    {
        var assignment = await GetAssignment(id);
        if (assignment is null) return null;

        assignment.Priority = priority;
        indexDbContext.Assignments.Update(assignment);
        await indexDbContext.SaveChangesAsync();
        await UpdateLastModifiedDate(assignment.Id);

        return new AssignmentVm
        {
            Id = assignment.Id,
            Name = assignment.Name,
            Priority = assignment.Priority,
            Status = assignment.Status,
            StartDate = assignment.StartDate,
            DueDate = assignment.DueDate
        };
    }

    public async Task<AssignmentVm?> UpdateAssignmentStatus(int id, AssignmentStatus status)
    {
        var assignment = await GetAssignment(id);
        if (assignment is null) return null;

        assignment.Status = status;
        indexDbContext.Assignments.Update(assignment);
        await indexDbContext.SaveChangesAsync();
        await UpdateLastModifiedDate(id);

        return new AssignmentVm()
        {
            Id = assignment.Id,
            Name = assignment.Name,
            Priority = assignment.Priority,
            Status = assignment.Status,
            StartDate = assignment.StartDate,
            DueDate = assignment.DueDate
        };
    }
}