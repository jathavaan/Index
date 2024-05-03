namespace Index.Application.Features.ReportCard.Command.AddSubjectToReportCard;

public class AddSubjectToReportCardCommandValidator : AbstractValidator<AddSubjectToReportCardCommand>
{
    public AddSubjectToReportCardCommandValidator()
    {
        RuleFor(x => x.Grade)
            .GreaterThanOrEqualTo(-2)
            .LessThanOrEqualTo(5);
    }
}