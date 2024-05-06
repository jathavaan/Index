namespace Index.Application.Features.Assignment.Command.EditAssignmentPriority;

public class EditAssignmentPriorityCommandValidator : AbstractValidator<EditAssignmentPriorityCommand>
{
    public EditAssignmentPriorityCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull();

        RuleFor(x => (int)x.Priority)
            .InclusiveBetween(1, 4);
    }
}