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
                ,map => map.MapFrom(src => $"{src.DepartmentRegister.Title}"))
            .ForMember(x => x.SpentTime
                ,map => map.MapFrom(src => CalculateTimeSpent(src.TaskRegisters.ToList())));
    }

    public int CalculateTimeSpent(List<TaskRegister> taskRegisters)
    {
        int timeSpent = 0;

        timeSpent = taskRegisters.Sum(tk => tk.Duration);

        return timeSpent;
    }
}

