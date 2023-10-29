using Microsoft.EntityFrameworkCore;
using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly DatabaseContext _context;

    public BaseRepository(DatabaseContext context)
        => _context = context;

    public async Task AddAsync(T entity)
        => await _context.AddAsync(entity);
   
    public void Delete(T entity)
        => _context.Remove(entity);

    public async Task<List<T>> GetAllAsync()
        => await _context.Set<T>().ToListAsync();

    public async Task<T?> GetByIdAsync(long id)
        => await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

    public void Update(T entity)
        => _context.Update(entity);
    
}
