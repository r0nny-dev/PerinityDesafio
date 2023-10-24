using MediatR;

namespace PerinityDesafio.Application.UseCases.CreateDepartment;

public sealed record CreateDepartmentRequest(string Title): IRequest<CreateDepartmentResponse>;
