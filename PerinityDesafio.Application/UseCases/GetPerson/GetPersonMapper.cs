using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.GetPerson;

public sealed class GetPersonMapper : Profile
{
    public GetPersonMapper()
    {
        CreateMap<GetPersonRequest, PersonRegister>();
        CreateMap<PersonRegister, GetPersonResponse>()
            .ForMember(x => x.DepartmentTitle
                , map => map.MapFrom(src => $"{src.DepartmentRegister.Title}"))
            .ForMember(x => x.AverageSpentTime
                , map => map.MapFrom(src => src.TaskRegisters.Any() ? src.TaskRegisters.Average(task => task.Duration) : 0));    
    }
}
