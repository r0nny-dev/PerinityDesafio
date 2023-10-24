using MediatR;

namespace PerinityDesafio.Application.UseCases.CreateTask;

public sealed record CreateTaskRequest(string Title, string Description, DateTime Deadline, short Duration, bool Finished, long DepartmentRegisterId, long? PersonRegisterId) : IRequest<CreateTaskResponse>;
