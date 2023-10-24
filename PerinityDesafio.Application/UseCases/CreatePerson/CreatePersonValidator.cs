using FluentValidation;

namespace PerinityDesafio.Application.UseCases.CreatePerson;

public sealed class CreatePersonValidator: AbstractValidator<CreatePersonRequest>
{
    public CreatePersonValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.DepartmentRegisterId).NotNull();
    }
}
