using MediatR;
using Microsoft.AspNetCore.Mvc;
using PerinityDesafio.Application.UseCases.AllocatePerson;
using PerinityDesafio.Application.UseCases.CreateTask;
using PerinityDesafio.Application.UseCases.FinishTask;
using PerinityDesafio.Application.UseCases.PendingTask;

namespace PerinityDesafio.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly IMediator _mediator;

    public TaskController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("pendentes")]
    public async Task<ActionResult<List<PendingTaskResponse>>> GetPending(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new PendingTaskRequest(), cancellationToken);

        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<CreateTaskResponse>> Create(CreateTaskRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }

    [HttpPut("alocar/{id}")]
    public async Task<ActionResult<AllocatePersonResponse>> Allocate(long id, AllocatePersonRequest allocatePersonRequest)
    {
        if (id != allocatePersonRequest.AllocatedTask.Id) return BadRequest();

        var response = await _mediator.Send(allocatePersonRequest);

        return Ok(response);
    }

    [HttpPut("finalizar/{id}")]
    public async Task<ActionResult<FinishTaskResponse>> Finish(long id, CancellationToken cancellationToken)
    {
        var finishTaskRequest = new FinishTaskRequest(id);

        var response = await _mediator.Send(finishTaskRequest);

        return Ok(response);
    }
}
