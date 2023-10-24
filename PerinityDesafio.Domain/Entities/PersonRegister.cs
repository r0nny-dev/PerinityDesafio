namespace PerinityDesafio.Domain.Entities;

public class PersonRegister : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public long DepartmentRegisterId { get; set; }
    public DepartmentRegister DepartmentRegister { get; set; }
    public ICollection<TaskRegister> TaskRegisters { get; set; }

}
