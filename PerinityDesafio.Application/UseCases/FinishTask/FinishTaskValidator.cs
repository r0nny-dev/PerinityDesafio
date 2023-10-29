using FluentValidation;

namespace PerinityDesafio.Application.UseCases.FinishTask;

public class FinishTaskValidator : AbstractValidator<FinishTaskRequest>
{
    public FinishTaskValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
