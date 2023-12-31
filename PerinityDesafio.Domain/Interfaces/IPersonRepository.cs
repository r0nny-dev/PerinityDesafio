﻿using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Domain.Interfaces;

public interface IPersonRepository : IBaseRepository<PersonRegister>
{
    Task<List<PersonRegister>> GetAllPerson(CancellationToken cancellationToken);
    Task<PersonRegister?> GetPersonByName(string name, CancellationToken cancellationToken);
}
