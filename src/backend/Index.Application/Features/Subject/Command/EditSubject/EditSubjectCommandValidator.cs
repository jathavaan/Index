using System.Data;

namespace Index.Application.Features.Subject.Command.EditSubject;

public class EditSubjectCommandValidator : AbstractValidator<EditSubjectCommand>
{
    public EditSubjectCommandValidator()
    {
        RuleFor(x => x.SubjectCode)
            .MinimumLength(6)
            .MaximumLength(7);

        RuleFor(x => x.Credits)
            .InclusiveBetween(0, 60);
    }
}