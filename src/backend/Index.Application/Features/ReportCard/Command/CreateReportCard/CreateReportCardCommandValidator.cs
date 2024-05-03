namespace Index.Application.Features.ReportCard.Command.CreateReportCard;

public class CreateReportCardCommandValidator : AbstractValidator<CreateReportCardCommand>
{
    public CreateReportCardCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();

        RuleFor(x => x.UserProfileProfileId)
            .NotEmpty();
    }
}