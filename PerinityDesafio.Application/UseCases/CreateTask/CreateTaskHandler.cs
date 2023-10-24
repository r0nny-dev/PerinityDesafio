using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.CreateTask;

public class CreateTaskHandler : IRequestHandler<CreateTaskRequest, CreateTaskResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    public CreateTaskHandler(IUnitOfWork unitOfWork, ITaskRepository taskRepository, IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _taskRepository = taskRepository;
    }

    public async Task<CreateTaskResponse> Handle(CreateTaskRequest request, CancellationToken cancellationToken)
    {
        var task = _mapper.Map<TaskRegister>(request);

        await _taskRepository.AddAsync(task);

        await _unitOfWork.Commit();

        return _mapper.Map<CreateTaskResponse>(task);
    }
}
