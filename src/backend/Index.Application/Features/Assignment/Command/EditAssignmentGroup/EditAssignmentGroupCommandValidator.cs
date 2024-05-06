namespace Index.Application.Features.Assignment.Command.EditAssignmentGroup;

public class EditAssignmentGroupCommandValidator : AbstractValidator<EditAssignmentGroupCommand>
{
    public EditAssignmentGroupCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull();
    }
}