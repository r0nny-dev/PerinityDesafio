using AutoMapper;
using MediatR;
using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.GetPerson;

public sealed class GetPersonHandler : IRequestHandler<GetPersonRequest, GetPersonResponse>
{
    private readonly IMapper _mapper;
    private readonly IPersonRepository _personRepository;

    public GetPersonHandler(IMapper mapper, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _personRepository = personRepository;
    }

    public async Task<GetPersonResponse> Handle(GetPersonRequest request, CancellationToken cancellationToken)
    {
        var person = await _personRepository.GetPersonByName(request.Name, cancellationToken);

        if (person is null) return default;

        var listTaskByPeriod = person.TaskRegisters
                                  .Where(tk => tk.Deadline >= request.FirstPeriod && 
                                               tk.Deadline <= request.FinalPeriod).ToList();

        person.TaskRegisters = listTaskByPeriod;

        return _mapper.Map<GetPersonResponse>(person);
    }
}
