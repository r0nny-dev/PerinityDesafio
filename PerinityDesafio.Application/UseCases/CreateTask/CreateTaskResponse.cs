namespace PerinityDesafio.Application.UseCases.CreateTask;

public sealed record CreateTaskResponse
{
    public long Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public short Duration { get; set; }
    public bool Finished { get; set; }
    public long? PersonRegisterId { get; set; }
    public long DepartmentRegisterId { get; set; }
}
