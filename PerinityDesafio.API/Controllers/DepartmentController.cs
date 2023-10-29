using MediatR;
using Microsoft.AspNetCore.Mvc;
using PerinityDesafio.Application.UseCases.CreateDepartment;
using PerinityDesafio.Application.UseCases.GetDepartment;

namespace PerinityDesafio.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController : ControllerBase
{
    private readonly IMediator _mediator;

    public DepartmentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetDepartmentResponse>>> GetDepartments(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetDepartmentRequest(), cancellationToken);

        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<CreateDepartmentResponse>> Create(CreateDepartmentRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }
}
