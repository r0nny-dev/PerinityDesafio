namespace PerinityDesafio.Application.UseCases.DeletePerson;

public sealed record DeletePersonResponse
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long DepartmentRegisterId { get; set; }
}

