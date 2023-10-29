using Microsoft.EntityFrameworkCore;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.Infrastructure.Repositories;

public class TaskRepository : BaseRepository<TaskRegister>, ITaskRepository
{
    private readonly DatabaseContext _databaseContext;

    public TaskRepository(DatabaseContext context) : base(context)
    {
        _databaseContext = context;
    }

    public async Task<TaskRegister?> GetByIdTask(long id)
        => await _databaseContext.TaskRegisters
                .Include(tk => tk.PersonRegister)
                .Include(tk => tk.DepartmentRegister)
                .FirstOrDefaultAsync(x => x.Id == id);

}
