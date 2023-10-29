using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.UpdatePerson;

public sealed class UpdatePersonMapper : Profile
{
    public UpdatePersonMapper()
    {
        CreateMap<UpdatePersonRequest, PersonRegister>();
        CreateMap<PersonRegister, UpdatePersonResponse>();
    }
}
