namespace PerinityDesafio.Application.UseCases.AllocatePerson;

public sealed record AllocatePersonResponse
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public short Duration { get; set; }
    public bool Finished { get; set; }

    public string AllocatedPerson { get; set; } = string.Empty;

    public string DepartmentTitle { get; set; } = string.Empty;
}
