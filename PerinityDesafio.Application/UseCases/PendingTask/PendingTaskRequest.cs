using MediatR;

namespace PerinityDesafio.Application.UseCases.PendingTask;

public sealed record PendingTaskRequest() : IRequest<List<PendingTaskResponse>>;
