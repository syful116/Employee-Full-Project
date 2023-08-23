using EmployeeProjectTeam04.Core.City.Command;
using EmployeeProjectTeam04.Core.City.Query;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProjectTeam04.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    private readonly IMediator _mediator;
    public CityController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult<VmCity>> Get()
    {
        var data = await _mediator.Send(new GetAllCity());
        return Ok(data);
    }
    [HttpGet("id")]
    public async Task<ActionResult<VmCity>> Get(int id)
    {
        var data = await _mediator.Send(new GetCityById(id));
        return Ok(data);
    }
    [HttpPost]
    public async Task<ActionResult<VmCity>> PostAsync([FromForm] VmCity vmCity)
    {
        var data = await _mediator.Send(new CreateCity(vmCity));
        return Ok(data);

    }

    [HttpPut("id")]
    public async Task<ActionResult<VmCity>> PutAsync(int id, [FromForm] VmCity vmCity)
    {
        var data = await _mediator.Send(new UpdateCity(id, vmCity));
        return Ok(data);
    }
    [HttpDelete("id")]
    public async Task<ActionResult<VmCity>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeleteCity(id));
        return Ok(data);
    }
}