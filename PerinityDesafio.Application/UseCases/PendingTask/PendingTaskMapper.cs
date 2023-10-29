using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.PendingTask;

public sealed class PendingTaskMapper : Profile
{
    public PendingTaskMapper()
    {
        CreateMap<TaskRegister, PendingTaskResponse>()
            .ForMember(x => x.DepartmentTitle
                , map => map.MapFrom(src => $"{src.DepartmentRegister.Title}"));
    }
}
