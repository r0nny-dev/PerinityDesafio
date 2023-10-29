using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.GetDepartment;

public sealed class GetDepartmentHandler : IRequestHandler<GetDepartmentRequest, List<GetDepartmentResponse>>
{
    private readonly IMapper _mapper;
    private readonly IDepartmentRepository _departmentRepository;

    public GetDepartmentHandler(IMapper mapper, IDepartmentRepository departmentRepository)
    {
        _mapper = mapper;
        _departmentRepository = departmentRepository;
    }

    public async Task<List<GetDepartmentResponse>> Handle(GetDepartmentRequest request, CancellationToken cancellationToken)
    {
        var departmentRegisters = await _departmentRepository.GetDepartments(cancellationToken);

        return _mapper.Map<List<GetDepartmentResponse>>(departmentRegisters); 
    }
}
