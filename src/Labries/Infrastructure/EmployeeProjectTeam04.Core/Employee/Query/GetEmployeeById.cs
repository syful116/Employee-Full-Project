using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.Employee.Query;
public record GetEmployeeById(int Id) : IRequest<VmEmployee>;

public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeById, VmEmployee>
{
    private readonly IEmployeeRepository _employeeRepository;
    public GetEmployeeByIdHandler(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    public async Task<VmEmployee> Handle(GetEmployeeById request, CancellationToken cancellationToken)
    {
        return await _employeeRepository.GetById(request.Id);
    }
}