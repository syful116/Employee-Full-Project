using EmployeeProjectTeam04.Shared.Common;

namespace EmployeeProjectTeam04.Services.Model;

public class VmDepartment : IVm
{
    public int Id { get; set; }
    public string? DepartmentName { get; set; }

}