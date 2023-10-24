using MediatR;
using Microsoft.AspNetCore.Mvc;
using PerinityDesafio.Application.UseCases.CreatePerson;

namespace PerinityDesafio.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly IMediator _mediator;

    public PersonController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CreatePersonResponse>> Create(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }

}
