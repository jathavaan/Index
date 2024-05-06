namespace Index.Application.Features.Assignment.Command.CreateAssignmentGroup;

public class CreateAssignmentGroupCommandValidator : AbstractValidator<CreateAssignmentGroupCommand>
{
    public CreateAssignmentGroupCommandValidator()
    {
        RuleFor(x => x.SubjectCode)
            .NotNull()
            .NotEmpty()
            .MaximumLength(8)
            .WithMessage("Subject code must be less than or equal to 8 characters.");

        RuleFor(x => x.UserProfileId)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.TotalAssignments)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Total assignments must be greater than or equal to 0.");

        RuleFor(x => x.RequiredAssignments)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Required assignments must be greater than or equal to 0.")
            .LessThanOrEqualTo(x => x.TotalAssignments)
            .WithMessage("Required assignments must be less than or equal to total assignments.");
    }
}