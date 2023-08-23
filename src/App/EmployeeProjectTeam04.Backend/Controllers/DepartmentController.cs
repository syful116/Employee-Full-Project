using EmployeeProjectTeam04.Core.Department.Command;
using EmployeeProjectTeam04.Core.Department.Query;
using EmployeeProjectTeam04.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProjectTeam04.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<ActionResult<VmDepartment>> Get()
        {
            var data = await _mediator.Send(new GetAllDepartmentQuery());
            return Ok(data);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<VmDepartment>> GetbyId(int id)
        {
            var data = await _mediator.Send(new GetDepartmentById(id));
            return Ok(data);

        }

        [HttpPost]
        public async Task<ActionResult<VmDepartment>> PostAsync([FromForm] VmDepartment vmdepartment)
        {
            var data = await _mediator.Send(new CreateDepartment(vmdepartment));
            return Ok(data);
        }

        [HttpDelete("id")]
        public async Task<ActionResult<VmDepartment>> DeleteAsync(int id)
        {
            var data = await _mediator.Send(new DeleteDepartment(id));
            return Ok(data);
        }

    }
}

