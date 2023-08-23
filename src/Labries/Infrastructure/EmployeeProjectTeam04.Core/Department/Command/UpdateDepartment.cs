using AutoMapper;
using EmployeeProjectTeam04.Repositories.Interface;
using EmployeeProjectTeam04.Services.Model;
using MediatR;


namespace EmployeeProjectTeam04.Core.Department.Command;

public record UpdateDepartment(int Id, VmDepartment
VmDepartment) : IRequest<VmDepartment>;
public class UpdateDepartmentHandler :
IRequestHandler<UpdateDepartment, VmDepartment>
{
    private readonly IDepartmentRepositpry _departmentRepositpry;
    private readonly IMapper _mapper;

    public UpdateDepartmentHandler(IDepartmentRepositpry departmentRepositpry, IMapper mapper)
    {
        _departmentRepositpry = departmentRepositpry;
        _mapper = mapper;
    }

    public async Task<VmDepartment> Handle(UpdateDepartment request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Entity.Department>(request.VmDepartment);
        return await _departmentRepositpry.Update(request.Id, data);
    }
}