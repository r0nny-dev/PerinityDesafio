using FluentValidation;
using PerinityDesafio.Application.UseCases.CreatePerson;

namespace PerinityDesafio.Application.UseCases.CreateTask;

public sealed class CreateTaskValidator : AbstractValidator<CreateTaskRequest>
{
    public CreateTaskValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Description).NotEmpty().MinimumLength(3).MaximumLength(250);
        RuleFor(x => x.Deadline).NotNull();
        RuleFor(x => x.Duration).NotNull();
        RuleFor(x => x.Finished).NotNull();
        RuleFor(x => x.DepartmentRegisterId).NotNull();
    }
}
