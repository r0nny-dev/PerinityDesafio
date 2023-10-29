
using Microsoft.EntityFrameworkCore;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.Infrastructure.Repositories;

public class PersonRepository : BaseRepository<PersonRegister>, IPersonRepository
{
    private readonly DatabaseContext _context;

    public PersonRepository(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<PersonRegister>> GetAllPerson(CancellationToken cancellationToken)
    {
        return await _context.Persons
            .Include(ps => ps.DepartmentRegister)
            .Include(ps => ps.TaskRegisters)
            .ToListAsync();
    }

    public async Task<PersonRegister?> GetPersonByName(string name, CancellationToken cancellationToken)
    {
        return await _context.Persons
            .Include(ps => ps.DepartmentRegister)
            .Include(ps => ps.TaskRegisters)
            .FirstOrDefaultAsync(x => x.Name == name);
    }
}
