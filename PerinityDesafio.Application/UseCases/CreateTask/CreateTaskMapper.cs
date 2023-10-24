using AutoMapper;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.CreateTask;

 public class CreateTaskMapper : Profile
{
    public CreateTaskMapper()
    {
        CreateMap<CreateTaskRequest, TaskRegister>();
        CreateMap<TaskRegister, CreateTaskResponse>();
    }
}
