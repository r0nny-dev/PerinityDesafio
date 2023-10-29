using FluentValidation;

namespace PerinityDesafio.Application.UseCases.GetAllPerson;

public class GetAllPersonValidator : AbstractValidator<GetAllPersonRequest>
{
    public GetAllPersonValidator()
    {
        //Não tem Validações
    }
}
