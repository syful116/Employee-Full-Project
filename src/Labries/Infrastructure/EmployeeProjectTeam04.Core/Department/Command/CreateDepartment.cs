using AutoMapper;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;

namespace EmployeeProjectTeam04.Core.Department.Command

{
    public record CreateDepartment(VmDepartment VmDepartment) :
       IRequest<VmDepartment>;
public class CrateDepartmentHandler :
IRequestHandler<CreateDepartment, VmDepartment>
{
    private readonly IDepartmentRepositpry _departmentRepositpry;
    private readonly IMapper _mapper;

    public CrateDepartmentHandler(IDepartmentRepositpry departmentRepositpry, IMapper mapper)
    {
        _departmentRepositpry = departmentRepositpry;
        _mapper = mapper;
    }

    public async Task<VmDepartment> Handle(CreateDepartment request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Entity.Department>(request.VmDepartment);
        return await _departmentRepositpry.Add(data);
    }
}
}