using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.DeletePerson;

public sealed class DeletePersonHandler : IRequestHandler<DeletePersonRequest, DeletePersonResponse>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPersonRepository _personRepository;

    public DeletePersonHandler(IMapper mapper, IUnitOfWork unitOfWork, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _personRepository = personRepository;
    }

    public async Task<DeletePersonResponse?> Handle(DeletePersonRequest request, CancellationToken cancellationToken)
    {
        var person = await _personRepository.GetByIdAsync(request.Id);

        if (person is null) return default;

        _personRepository.Delete(person);

        await _unitOfWork.Commit();

        return _mapper.Map<DeletePersonResponse>(person);
    }
}
