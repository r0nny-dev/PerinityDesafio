using AutoMapper;
using PerinityDesafio.Application.UseCases.CreatePerson;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Application.UseCases.CreateDepartment;

public class CreateDepartmentMapper : Profile
{
    public CreateDepartmentMapper()
    {
        CreateMap<CreateDepartmentRequest, DepartmentRegister>();
        CreateMap<DepartmentRegister, CreateDepartmentResponse>();
    }
}
