using PerinityDesafio.Domain.Interfaces;

namespace PerinityDesafio.Application.UseCases.GetAllPerson;

public sealed class GetAllPersonResponse
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string DepartmentRegisterTitle { get; set; } = string.Empty;

    public short SpentTime { get; set; }

}


