using MediatR;

namespace PerinityDesafio.Application.UseCases.GetPerson;

public sealed record GetPersonRequest(string Name, DateTime FirstPeriod, DateTime FinalPeriod) : IRequest<GetPersonResponse>;
