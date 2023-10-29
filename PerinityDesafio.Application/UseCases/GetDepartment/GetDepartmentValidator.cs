using FluentValidation;

namespace PerinityDesafio.Application.UseCases.GetDepartment;

public class GetDepartmentValidator : AbstractValidator<GetDepartmentRequest>
{
    public GetDepartmentValidator()
    {
        //Sem validações para esse método.
    }
}
