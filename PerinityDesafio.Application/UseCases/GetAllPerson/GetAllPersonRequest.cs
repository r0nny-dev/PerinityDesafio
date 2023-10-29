using MediatR;

namespace PerinityDesafio.Application.UseCases.GetAllPerson;

public sealed record GetAllPersonRequest() : IRequest<List<GetAllPersonResponse>>;
