namespace PerinityDesafio.Domain.Entities;

public class TaskRegister : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateOnly Deadline { get; set; }
    public short Duration { get; set; }
    public bool Finished { get; set; }
}
