using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.Infrastructure.Repositories;

public class DepartmantRepository : BaseRepository<DepartmentRegister>, IDepartmentRepository
{
    public DepartmantRepository(DatabaseContext context) : base(context)
    {}
}
