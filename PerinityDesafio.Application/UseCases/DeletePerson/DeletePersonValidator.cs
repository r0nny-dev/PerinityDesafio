using FluentValidation;

namespace PerinityDesafio.Application.UseCases.DeletePerson;

public class DeletePersonValidator : AbstractValidator<DeletePersonRequest>
{
    public DeletePersonValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
