namespace Index.Application.Features.StudyPlan.Command.StudyPlan.UpdateName;

public class UpdateStudyPlanNameCommandValidator : AbstractValidator<UpdateStudyPlanNameCommand>
{
    public UpdateStudyPlanNameCommandValidator()
    {
        RuleFor(x => x.StudyPlanId).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
    }
}