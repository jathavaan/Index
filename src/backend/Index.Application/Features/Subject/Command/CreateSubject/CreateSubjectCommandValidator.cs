namespace Index.Application.Features.Subject.Command.CreateSubject;

public class CreateSubjectCommandValidator : AbstractValidator<CreateSubjectCommand>
{
    public CreateSubjectCommandValidator()
    {
        RuleFor(x => x.Dto.SubjectCode)
            .NotEmpty()
            .MinimumLength(6)
            .MaximumLength(7);

        RuleFor(x => x.Dto.Name)
            .NotEmpty();

        RuleFor(x => x.Dto.Credit)
            .NotEmpty()
            .GreaterThanOrEqualTo(0)
            .WithMessage("Credits has to be greater or equal to 0")
            .LessThanOrEqualTo(60)
            .WithMessage("Credits has to be less or equal to 60");
    }
}