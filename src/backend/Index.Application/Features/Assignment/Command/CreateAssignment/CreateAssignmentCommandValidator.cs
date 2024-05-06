namespace Index.Application.Features.Assignment.Command.CreateAssignment;

public class CreateAssignmentCommandValidator : AbstractValidator<CreateAssignmentCommand>
{
    public CreateAssignmentCommandValidator()
    {
        RuleFor(x => x.Dto)
            .NotNull();

        RuleFor(x => x.Dto.Name)
            .NotEmpty();

        RuleFor(x => x.Dto.AssignmentGroupId)
            .NotEmpty();
    }
}