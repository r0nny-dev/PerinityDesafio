using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.FinishTask;

public sealed class FinishTaskHandler : IRequestHandler<FinishTaskRequest, FinishTaskResponse>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITaskRepository _taskRepository;

    public FinishTaskHandler(IMapper mapper, IUnitOfWork unitOfWork, ITaskRepository taskRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _taskRepository = taskRepository;
    }

    public async Task<FinishTaskResponse> Handle(FinishTaskRequest request, CancellationToken cancellationToken)
    {
        var task = await _taskRepository.GetByIdTask(request.Id);

        if (task is null) return default;

        task.Finished = true;

        _taskRepository.Update(task);

        await _unitOfWork.Commit();

        return _mapper.Map<FinishTaskResponse>(task);
    }
}
