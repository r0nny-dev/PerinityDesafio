using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.CreatePerson;

public class CreatePersonMapper : Profile
{
    public CreatePersonMapper()
    {
        CreateMap<CreatePersonRequest, PersonRegister>();
        CreateMap<PersonRegister, CreatePersonResponse>();
    }
}
