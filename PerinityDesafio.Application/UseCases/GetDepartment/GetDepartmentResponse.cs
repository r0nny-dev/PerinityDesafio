namespace PerinityDesafio.Application.UseCases.GetDepartment;

public sealed record GetDepartmentResponse
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int AllocatedPersons { get; set; }
    public int AllocatedTasks { get; set; }
}
