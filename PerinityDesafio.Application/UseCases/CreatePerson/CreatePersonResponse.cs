namespace PerinityDesafio.Application.UseCases.CreatePerson;

public sealed record CreatePersonResponse
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long DepartmentRegisterId { get; set; }
}
