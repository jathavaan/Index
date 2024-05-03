namespace Index.Application.Features.Subject.Command.DeleteSubject;

public class DeleteSubjectCommandValidator : AbstractValidator<DeleteSubjectCommand>
{
    public DeleteSubjectCommandValidator()
    {
        RuleFor(x => x.SubjectCode)
            .NotEmpty()
            .MinimumLength(6)
            .MaximumLength(7);
    }
}