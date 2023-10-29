using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.FinishTask;

public sealed class FinishTaskMapper : Profile
{
    public FinishTaskMapper()
    {
        CreateMap<FinishTaskRequest, TaskRegister>();
        CreateMap<TaskRegister, FinishTaskResponse>()
            .ForMember(x => x.AllocatedPerson
                ,map => map.MapFrom(src => $"{src.PersonRegister.Name}"))
            .ForMember(x => x.DepartmentTitle
                ,map => map.MapFrom(src => $"{src.DepartmentRegister.Title}"));
    }
}
