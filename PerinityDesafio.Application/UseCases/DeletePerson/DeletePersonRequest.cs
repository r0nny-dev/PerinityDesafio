using MediatR;

namespace PerinityDesafio.Application.UseCases.DeletePerson;

public sealed record DeletePersonRequest(long Id) : IRequest<DeletePersonResponse>;
