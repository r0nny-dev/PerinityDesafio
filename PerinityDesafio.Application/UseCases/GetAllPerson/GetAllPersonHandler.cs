using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.GetAllPerson;

public sealed class GetAllPersonHandler : IRequestHandler<GetAllPersonRequest, List<GetAllPersonResponse>>
{
    private readonly IMapper _mapper;
    private readonly IPersonRepository _personRepository;

    public GetAllPersonHandler(IMapper mapper, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _personRepository = personRepository;
    }

    public async Task<List<GetAllPersonResponse>> Handle(GetAllPersonRequest request, CancellationToken cancellationToken)
    {
        var persons = await _personRepository.GetAllPerson(cancellationToken);

        return _mapper.Map<List<GetAllPersonResponse>>(persons);
    }
}
