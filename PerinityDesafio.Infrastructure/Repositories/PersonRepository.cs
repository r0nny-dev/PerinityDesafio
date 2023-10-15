using PerinityDesafio.Domain.Entities;
using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.Infrastructure.Repositories;

public class PersonRepository : BaseRepository<PersonRegister>, IPersonRepository
{
    public PersonRepository(DatabaseContext context) : base(context)
    {}
}
