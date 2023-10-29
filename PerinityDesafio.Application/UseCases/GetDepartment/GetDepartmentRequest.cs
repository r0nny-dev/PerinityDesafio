using MediatR;

namespace PerinityDesafio.Application.UseCases.GetDepartment;

public sealed record GetDepartmentRequest() : IRequest<List<GetDepartmentResponse>>;
