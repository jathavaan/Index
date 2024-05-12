namespace Index.Application.Features.StudyPlan.Command.StudyPlan.Create;

public class CreateStudyPlanCommandValidator : AbstractValidator<CreateStudyPlanCommand>
{
    public CreateStudyPlanCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.UserProfileId).NotEmpty();
    }
}