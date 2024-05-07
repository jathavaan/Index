namespace Index.Application.Features.Assignment.Command.EditAssignmentName;

public class EditAssignmentNameCommandValidator : AbstractValidator<EditAssignmentNameCommand>
{
    public EditAssignmentNameCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id is required")
            .NotNull();

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .NotNull()
            .MaximumLength(100)
            .WithMessage("Name must not exceed 100 characters");
    }
}