using AutoMapper;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.GetAllPerson;

public sealed class GetAllPersonMapper : Profile
{
    public GetAllPersonMapper()
    {
        CreateMap<PersonRegister, GetAllPersonResponse>()
            .ForMember(x => x.DepartmentRegisterTitle
                , map => map.MapFrom(src => $"{src.DepartmentRegister.Title}"))
            .ForMember(x => x.SpentTime
                , map => map.MapFrom(src => src.TaskRegisters.Any() ? src.TaskRegisters.Sum(task => task.Duration) : 0));
    }
}

