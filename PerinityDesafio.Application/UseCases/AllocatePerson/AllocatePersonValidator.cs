using FluentValidation;

namespace PerinityDesafio.Application.UseCases.AllocatePerson;

public class AllocatePersonValidator : AbstractValidator<AllocatePersonRequest>
{
    public AllocatePersonValidator()
    {
        //Validator Person
        RuleFor(x => x.AllocatedPerson.Id);
        RuleFor(x => x.AllocatedPerson.Name);
        RuleFor(x => x.AllocatedPerson.DepartmentRegisterId);

        //Validator Task
        RuleFor(x => x.AllocatedTask.Id).NotNull();
    }
}
