using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.GetDepartment;

public sealed class GetDepartmentMapper : Profile
{
    public GetDepartmentMapper()
    {
        CreateMap<DepartmentRegister, GetDepartmentResponse>()
            .ForMember(x => x.AllocatedPersons
                ,map => map.MapFrom(src => src.PersonRegisters.Count()))
            .ForMember(x => x.AllocatedTasks
                ,map => map.MapFrom(src => src.TaskRegisters.Count()));
    }
}
