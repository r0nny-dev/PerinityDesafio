using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.Infrastructure.Repositories;

public class TaskRepository : BaseRepository<TaskRegister>, ITaskRepository
{
    public TaskRepository(DatabaseContext context) : base(context)
    {
    }
}
