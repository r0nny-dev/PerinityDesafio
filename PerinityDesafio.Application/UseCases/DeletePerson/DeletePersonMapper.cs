using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.DeletePerson;

public sealed class DeletePersonMapper : Profile
{
    public DeletePersonMapper()
    {
        CreateMap<DeletePersonRequest, PersonRegister>();
        CreateMap<PersonRegister, DeletePersonResponse>();
    }
}
