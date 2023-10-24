namespace PerinityDesafio.Application.UseCases.CreateDepartment;

public sealed record CreateDepartmentResponse
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
}
