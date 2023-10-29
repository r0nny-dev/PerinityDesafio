namespace PerinityDesafio.Application.UseCases.AllocatePerson;

public sealed record AllocatedPerson
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long DepartmentRegisterId { get; set; }
}
