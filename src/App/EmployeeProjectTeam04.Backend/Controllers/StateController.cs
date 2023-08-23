using EmployeeProjectTeam04.Core.State.Command;
using EmployeeProjectTeam04.Core.State.Query;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProjectTeam04.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StateController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<VmState>> Get()
        {
            var data = await _mediator.Send(new GetAllState());
            return Ok(data);
        }
        [HttpGet("id")]
        public async Task<ActionResult<VmState>> Get(int id)
        {
            var data = await _mediator.Send(new GetStateById(id));
            return Ok(data);
        }
        [HttpPost]
        public async Task<ActionResult<VmState>> PostAsync([FromForm] VmState vmState)
        {
            var data = await _mediator.Send(new CreateState(vmState));
            return Ok(data);

        }

        [HttpPut("id")]
        public async Task<ActionResult<VmState>> PutAsync(int id, [FromForm] VmState vmState)
        {
            var data = await _mediator.Send(new UpdateState(id, vmState));
            return Ok(data);
        }
        [HttpDelete("id")]
        public async Task<ActionResult<VmState>> DeleteAsync(int id)
        {
            var data = await _mediator.Send(new DeleteState(id));
            return Ok(data);
        }
    }
}