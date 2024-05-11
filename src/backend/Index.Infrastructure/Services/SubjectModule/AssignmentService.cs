using Index.Application.Contracts.SubjectModule.Dtos;

namespace Index.Infrastructure.Services.SubjectModule;

public class AssignmentService : IAssignmentService
{
    private readonly IndexDbContext _context;

    public AssignmentService(IndexDbContext context)
    {
        _context = context;
    }

    public async Task<Assignment?> GetAssignment(int id)
    {
        return await _context.Assignments
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();
    }

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

    public async Task<bool> DeleteAssignment(Assignment assignment)
    {
        _context.Assignments.Remove(assignment);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<AssignmentVm> UpdateAssignmentName(Assignment assignment, string name)
    {
        assignment.Name = name;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
        await UpdateLastModifiedDate(assignment);

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

    public async Task<bool> UpdateLastModifiedDate(Assignment assignment)
    {
        assignment.DateModified = DateTime.Now;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<AssignmentVm> UpdateAssignmentPriority(Assignment assignment, AssignmentPriority priority)
    {
        assignment.Priority = priority;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
        await UpdateLastModifiedDate(assignment);

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

    public async Task<AssignmentVm> UpdateAssignmentStatus(Assignment assignment, AssignmentStatus status)
    {
        assignment.Status = status;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
        await UpdateLastModifiedDate(assignment);

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

    public async Task<AssignmentVm> UpdateAssignmentStartDate(Assignment assignment, DateTime startDate)
    {
        assignment.StartDate = startDate;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
        await UpdateLastModifiedDate(assignment);

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

    public async Task<AssignmentVm> UpdateAssignmentDueDate(Assignment assignment, DateTime dueDate)
    {
        assignment.DueDate = dueDate;
        _context.Assignments.Update(assignment);
        await _context.SaveChangesAsync();
        await UpdateLastModifiedDate(assignment);

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
}