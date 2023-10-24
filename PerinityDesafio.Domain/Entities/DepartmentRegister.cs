namespace PerinityDesafio.Domain.Entities;

public class DepartmentRegister : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public virtual ICollection<PersonRegister> PersonRegisters { get; set; } 
    
    public virtual ICollection<TaskRegister> TaskRegisters { get; set; } 
}
