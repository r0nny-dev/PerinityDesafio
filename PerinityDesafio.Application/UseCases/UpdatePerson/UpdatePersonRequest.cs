using MediatR;

namespace PerinityDesafio.Application.UseCases.UpdatePerson;

public sealed record UpdatePersonRequest(long Id, string Name, long DepartmentRegisterId) : IRequest<UpdatePersonResponse>;

