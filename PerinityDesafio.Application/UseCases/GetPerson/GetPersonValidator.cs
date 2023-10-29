using FluentValidation;

namespace PerinityDesafio.Application.UseCases.GetPerson;

public class GetPersonValidator : AbstractValidator<GetPersonRequest>
{
    public GetPersonValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.FirstPeriod).NotNull();
        RuleFor(x => x.FinalPeriod).NotNull();
    }
}
