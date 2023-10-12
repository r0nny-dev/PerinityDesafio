namespace PerinityDesafio.Domain.Interfaces;

public interface IUnitOfWork
{
    Task Commit();
}
