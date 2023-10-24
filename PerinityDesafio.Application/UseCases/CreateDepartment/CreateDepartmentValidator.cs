using FluentValidation;

namespace PerinityDesafio.Application.UseCases.CreateDepartment;

public class CreateDepartmentValidator : AbstractValidator<CreateDepartmentRequest>
{
    public CreateDepartmentValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}
