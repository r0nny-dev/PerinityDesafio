using MediatR;

namespace PerinityDesafio.Application.UseCases.AllocatePerson;

public sealed record AllocatePersonRequest(AllocatedPerson AllocatedPerson, AllocatedTask AllocatedTask) : IRequest<AllocatePersonResponse>;
