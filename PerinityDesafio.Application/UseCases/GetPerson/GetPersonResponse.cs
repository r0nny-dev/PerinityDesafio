namespace PerinityDesafio.Application.UseCases.GetPerson;

public sealed record GetPersonResponse
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string DepartmentTitle { get; set; } = string.Empty;
    public double AverageSpentTime { get; set; }
}
