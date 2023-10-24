using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.CreateDepartment;

internal class CreateDepartmentHandler : IRequestHandler<CreateDepartmentRequest, CreateDepartmentResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IMapper _mapper;

    public CreateDepartmentHandler(IUnitOfWork  unitOfWork, IDepartmentRepository departmentRepository, IMapper mapper)
    {
        _departmentRepository = departmentRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreateDepartmentResponse> Handle(CreateDepartmentRequest request, CancellationToken cancellationToken)
    {
        var department = _mapper.Map<DepartmentRegister>(request);

        await _departmentRepository.AddAsync(department);

        await _unitOfWork.Commit();

        return _mapper.Map<CreateDepartmentResponse>(department);
    }
}
