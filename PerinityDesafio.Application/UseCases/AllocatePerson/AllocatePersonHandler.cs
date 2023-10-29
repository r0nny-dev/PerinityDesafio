using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.AllocatePerson;

public sealed class AllocatePersonHandler : IRequestHandler<AllocatePersonRequest, AllocatePersonResponse>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITaskRepository _taskRepository;
    private readonly IPersonRepository _personRepository;

    public AllocatePersonHandler(IMapper mapper, IUnitOfWork unitOfWork, ITaskRepository taskRepository, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _taskRepository = taskRepository;
        _personRepository = personRepository;
    }

    public async Task<AllocatePersonResponse?> Handle(AllocatePersonRequest request, CancellationToken cancellationToken)
    {

        var person = await _personRepository.GetByIdAsync(request.AllocatedPerson.Id);

        if (person is null) return default;

        var task = await _taskRepository.GetByIdTask(request.AllocatedTask.Id);

        if (task is null) return default;

        if (person.DepartmentRegisterId != task.DepartmentRegisterId)
            return default;

        task.PersonRegisterId = request.AllocatedPerson.Id;

        await _unitOfWork.Commit();

        return _mapper.Map<AllocatePersonResponse>(task);
    }
}
