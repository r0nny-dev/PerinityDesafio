using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.CreatePerson;

public class CreatePersonHandler : IRequestHandler<CreatePersonRequest, CreatePersonResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPersonRepository _personRepository;
    private readonly IMapper _mapper;

    public CreatePersonHandler(IUnitOfWork unitOfWork, IPersonRepository personRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _personRepository = personRepository;
        _mapper = mapper;
    }

    public async Task<CreatePersonResponse> Handle(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        var person = _mapper.Map<PersonRegister>(request);

        await _personRepository.AddAsync(person);

        await _unitOfWork.Commit();

        return _mapper.Map<CreatePersonResponse>(person);
    }
}
