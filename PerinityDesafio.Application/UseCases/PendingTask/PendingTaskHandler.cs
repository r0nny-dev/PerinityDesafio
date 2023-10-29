using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.PendingTask;

public sealed class PendingTaskHandler : IRequestHandler<PendingTaskRequest, List<PendingTaskResponse>>
{
    private readonly IMapper _mapper;
    private readonly ITaskRepository _taskRepository;

    public PendingTaskHandler(IMapper mapper, ITaskRepository taskRepository)
    {
        _mapper = mapper;
        _taskRepository = taskRepository;
    }

    public async Task<List<PendingTaskResponse>> Handle(PendingTaskRequest request, CancellationToken cancellationToken)
    {
        var taskRegisters = await _taskRepository.GetPending();

        return _mapper.Map<List<PendingTaskResponse>>(taskRegisters);
    }
}
