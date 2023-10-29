using MediatR;

namespace PerinityDesafio.Application.UseCases.FinishTask;

public sealed record FinishTaskRequest(long Id) : IRequest<FinishTaskResponse>;
