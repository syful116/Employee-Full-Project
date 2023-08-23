using EmployeeProjectTeam04.Core.Country.Command;
using EmployeeProjectTeam04.Core.Country.Query;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProjectTeam04.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : ControllerBase
{

    private readonly IMediator _mediator;
    public CountryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<VmCountry>> GetById()
    {
        var data = await _mediator.Send(new GetAllCountry());
        return Ok(data);
    }
    [HttpGet("id")]
    public async Task<ActionResult<VmCountry>> GetById(int id)
    {
        var data = await _mediator.Send(new GetCountryById(id));
        return Ok(data);
    }

    [HttpPost]
    public async Task<ActionResult<VmCountry>> Add([FromForm] VmCountry vmCountry)
    {
        var data = await _mediator.Send(new CreateCountry(vmCountry));
        return Ok(data);
    }

    [HttpPut("id")]

    public async Task<ActionResult<VmCountry>> Update(int id, [FromForm] VmCountry vmCountry)
    {
        var data = await _mediator.Send(new UpdateCountry(id, vmCountry));
        return Ok(data);
    }
    [HttpDelete("id")]
    public async Task<ActionResult<VmCountry>> Delete(int id)
    {
        var data = await _mediator.Send(new DeleteCountry(id));
        return Ok(data);
    }
}