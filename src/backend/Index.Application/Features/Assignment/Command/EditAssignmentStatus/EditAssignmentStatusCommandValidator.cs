namespace Index.Application.Features.Assignment.Command.EditAssignmentStatus;

public class EditAssignmentStatusCommandValidator : AbstractValidator<EditAssignmentStatusCommand>
{
    public EditAssignmentStatusCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull();

        RuleFor(x => (int)x.Status)
            .InclusiveBetween(1, 4);
    }
}