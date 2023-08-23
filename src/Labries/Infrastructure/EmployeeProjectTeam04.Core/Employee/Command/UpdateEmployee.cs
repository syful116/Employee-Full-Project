using AutoMapper;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.Employee.Command;
public record UpdateEmployee(int Id, VmEmployee VmEmployee) : IRequest<VmEmployee>;
public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployee, VmEmployee>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    public UpdateEmployeeHandler(IEmployeeRepository employeeRepository,
                                 IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }
    public async Task<VmEmployee> Handle(UpdateEmployee request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Entity.Employee>(request.VmEmployee);
        return await _employeeRepository.Update(request.Id, data);
    }
}
