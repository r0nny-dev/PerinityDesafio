using MediatR;
using Microsoft.AspNetCore.Mvc;
using PerinityDesafio.Application.UseCases.CreatePerson;
using PerinityDesafio.Application.UseCases.DeletePerson;
using PerinityDesafio.Application.UseCases.GetAllPerson;
using PerinityDesafio.Application.UseCases.GetPerson;
using PerinityDesafio.Application.UseCases.UpdatePerson;

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

    [HttpGet]
    public async Task<ActionResult<List<GetAllPersonResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllPersonRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpGet("gastos")]
    public async Task<ActionResult<GetPersonResponse>> GetGastos([FromQuery] GetPersonRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<CreatePersonResponse>> Create(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdatePersonResponse>> Update(long id, UpdatePersonRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id) return BadRequest();

        var responde = await _mediator.Send(request,cancellationToken);

        return Ok(responde);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<DeletePersonResponse>> Delete(long id, CancellationToken cancellationToken)
    {
        if (id == 0) return BadRequest();

        var deletePersonRequest = new DeletePersonRequest(Id: id);

        var response = await _mediator.Send(deletePersonRequest, cancellationToken);

        return Ok(response);
    }



}
