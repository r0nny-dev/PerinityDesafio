using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.UpdatePerson;

public sealed class UpdatePersonHandler : IRequestHandler<UpdatePersonRequest, UpdatePersonResponse>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPersonRepository _personRepository;

    public UpdatePersonHandler(IMapper mapper, IUnitOfWork unitOfWork, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _personRepository = personRepository;
    }

    public async Task<UpdatePersonResponse?> Handle(UpdatePersonRequest command, CancellationToken cancellationToken)
    {
        var person = await _personRepository.GetByIdAsync(command.Id);

        if (person is null) return default;

        person.Name = command.Name;
        person.DepartmentRegisterId = command.DepartmentRegisterId;

        _personRepository.Update(person);

        await _unitOfWork.Commit();

        return _mapper.Map<UpdatePersonResponse>(person);
    }
}
