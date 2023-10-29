using FluentValidation;

namespace PerinityDesafio.Application.UseCases.PendingTask;

public class PendingTaskValidator : AbstractValidator<PendingTaskRequest>
{
    public PendingTaskValidator()
    {
        //Sem validações para esse método 
    }
}
