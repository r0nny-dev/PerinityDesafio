using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly DatabaseContext _context;
    
    public UnitOfWork(DatabaseContext Context) 
    {
        _context = Context;
    }

    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }
}
