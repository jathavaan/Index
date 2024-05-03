namespace Index.Application.Features.UserProfile.Command.CreateUserProfileCommand;

public class CreateUserProfileCommandValidator : AbstractValidator<CreateUserProfileCommand>
{
    public CreateUserProfileCommandValidator()
    {
        RuleFor(x => x.Dto)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Dto.FirstName)
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.Dto.Surname)
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.Dto.Email)
            .EmailAddress()
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.Dto.Password)
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.Dto.AccessLevel)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(2)
            .NotEmpty()
            .NotNull();
    }
}