using MediatR;

namespace PerinityDesafio.Application.UseCases.CreatePerson;

public sealed record CreatePersonRequest(string Name, long DepartmentRegisterId) : IRequest<CreatePersonResponse>;