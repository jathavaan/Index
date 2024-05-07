namespace Index.Application.Features.Assignment.Command.EditAssignmentStartDate;

public class EditAssignmentStartDateCommandValidator : AbstractValidator<EditAssignmentStartDateCommand>
{
    public EditAssignmentStartDateCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id is required")
            .GreaterThan(0)
            .WithMessage("Id must be greater than 0");

        RuleFor(x => x.StartDate)
            .NotEmpty()
            .WithMessage("Start date is required");
    }
}