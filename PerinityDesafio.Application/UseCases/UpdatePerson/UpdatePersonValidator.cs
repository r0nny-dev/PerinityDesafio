using FluentValidation;

namespace PerinityDesafio.Application.UseCases.UpdatePerson;

public class UpdatePersonValidator : AbstractValidator<UpdatePersonRequest>
{
    public UpdatePersonValidator() 
    {
        RuleFor(x => x.Id).NotNull();
        RuleFor(x => x.Name).NotEmpty()
            .MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.DepartmentRegisterId).NotNull();
    }
}
