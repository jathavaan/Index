namespace Index.Application.Features.Assignment.Command.EditAssignmentDueDate;

public class EditAssignmentDueDateCommandValidator : AbstractValidator<EditAssignmentDueDateCommand>
{
    public EditAssignmentDueDateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.DueDate).NotEmpty();
    }
}