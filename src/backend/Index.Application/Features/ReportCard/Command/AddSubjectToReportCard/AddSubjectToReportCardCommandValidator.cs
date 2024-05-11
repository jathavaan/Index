namespace Index.Application.Features.ReportCard.Command.AddSubjectToReportCard;

public class AddSubjectToReportCardCommandValidator : AbstractValidator<AddSubjectToReportCardCommand>
{
    public AddSubjectToReportCardCommandValidator()
    {
        RuleFor(x => (int)x.Grade)
            .InclusiveBetween(-2, 5)
            .WithMessage("Grade must be between -2 and 5");

        RuleFor(x => x.Year)
            .LessThanOrEqualTo(DateTime.Now.Year)
            .WithMessage("Year must be less than or equal to the current year");

        RuleFor(x => (int)x.Semester)
            .InclusiveBetween(1, 3)
            .WithMessage("Semester must be between 1 and 3");
    }
}