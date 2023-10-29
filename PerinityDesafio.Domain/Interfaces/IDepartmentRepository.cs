using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Domain.Interfaces;

public interface IDepartmentRepository : IBaseRepository<DepartmentRegister>
{
    Task<List<DepartmentRegister>> GetDepartments(CancellationToken cancellationToken);
}
