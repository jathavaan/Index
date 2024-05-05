using Microsoft.AspNetCore.Authentication.BearerToken;

namespace Index.Application.Features.AssignmentGroup.Command.EditAssignmentGroup;

public class EditAssignmentGroupCommandValidator : AbstractValidator<EditAssignmentGroupCommand>
{
    public EditAssignmentGroupCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull();
    }
}