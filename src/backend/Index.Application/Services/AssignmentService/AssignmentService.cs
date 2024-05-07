namespace Index.Application.Services.AssignmentService;

public class AssignmentService : IAssignmentService
{
    private readonly IndexDbContext _context;

    public AssignmentService(IndexDbContext context)
        => _context = context;

    public async Task<Assignment?> GetAssignment(int id)
        => await _context.Assignments
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

        _context.Assignments.Add(assignemnt);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAssignment(int id)
    {
        var assignment = await GetAssignment(id);
        switch (assignment)
        {
            case not null:
                _context.Assignments.Remove(assignment);
                await _context.SaveChangesAsync();
                return true;
            case null:
                return false;
        }
    }

    public async Task<AssignmentVm?> UpdateAssignmentName(int id, string name)
    {
        var assignment = await GetAssignment(id);
        if (assignment is null) return null;

        assignment.Name = name;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
        await UpdateLastModifiedDate(id);

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

    public async Task<bool> UpdateLastModifiedDate(int id)
    {
        var assignment = await GetAssignment(id);
        switch (assignment)
        {
            case not null:
                assignment.DateModified = DateTime.Now;
                _context.Assignments.Update(assignment);
                await _context.SaveChangesAsync();
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
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
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
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
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

    public async Task<AssignmentVm?> UpdateAssignmentStartDate(int id, DateTime startDate)
    {
        var assignment = await GetAssignment(id);
        if (assignment is null) return null;

        assignment.StartDate = startDate;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
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

    public async Task<AssignmentVm?> UpdateAssignmentDueDate(int id, DateTime dueDate)
    {
        var assignment = await GetAssignment(id);
        if (assignment is null) return null;

        assignment.DueDate = dueDate;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
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