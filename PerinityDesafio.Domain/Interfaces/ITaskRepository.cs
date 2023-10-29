using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Domain.Interfaces;

public interface ITaskRepository : IBaseRepository<TaskRegister>
{
    Task<TaskRegister?> GetByIdTask(long id);
}
