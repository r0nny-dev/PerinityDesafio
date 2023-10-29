using Microsoft.EntityFrameworkCore;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.Infrastructure.Repositories;

public class DepartmantRepository : BaseRepository<DepartmentRegister>, IDepartmentRepository
{
    private readonly DatabaseContext _context;

    public DepartmantRepository(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<DepartmentRegister>> GetDepartments(CancellationToken cancellationToken)
        => await _context.Departments
                    .Include(dp => dp.PersonRegisters)
                    .Include(dp => dp.TaskRegisters)    
                    .ToListAsync();
}
