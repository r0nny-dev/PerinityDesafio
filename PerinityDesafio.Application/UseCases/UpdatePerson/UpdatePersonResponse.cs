namespace PerinityDesafio.Application.UseCases.UpdatePerson;

public sealed record UpdatePersonResponse
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long DepartmentRegisterId { get; set; }
}
