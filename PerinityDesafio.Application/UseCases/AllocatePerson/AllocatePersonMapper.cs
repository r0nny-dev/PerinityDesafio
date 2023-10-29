using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.AllocatePerson;

public sealed class AllocatePersonMapper : Profile
{
    public AllocatePersonMapper() 
    {
        CreateMap<TaskRegister,AllocatePersonResponse>()
            .ForMember(x => x.DepartmentTitle
                ,map => map.MapFrom(src => $"{src.DepartmentRegister.Title}"))
            .ForMember(x => x.AllocatedPerson
                ,map => map.MapFrom(src => $"{src.PersonRegister.Name}"));
    }
}
