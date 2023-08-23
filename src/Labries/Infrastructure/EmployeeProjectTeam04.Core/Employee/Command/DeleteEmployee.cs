using AutoMapper;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.Employee.Command;
public record DeleteEmployee(int Id) : IRequest<VmEmployee>;
public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployee, VmEmployee>
{
    private readonly IEmployeeRepository _employeeRepository;
    public DeleteEmployeeHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
    }
    public async Task<VmEmployee> Handle(DeleteEmployee request, CancellationToken cancellationToken)
    {
        return await _employeeRepository.Delete(request.Id);
    }
}

