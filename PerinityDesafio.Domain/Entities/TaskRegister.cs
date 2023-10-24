namespace PerinityDesafio.Domain.Entities;

public class TaskRegister : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public short Duration { get; set; }
    public bool Finished { get; set; }

    public long DepartmentRegisterId { get; set; }
    public DepartmentRegister DepartmentRegister { get; set; }

    public long? PersonRegisterId { get; set; }
    public PersonRegister? PersonRegister { get; set; }
}
