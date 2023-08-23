using EmployeeProjectTeam04.Shared.Common;

namespace EmployeeProjectTeam04.Model.Entity;

public class Department : BaseAuditableEntity, IEntity
{

    public int Id { get; set; }


    public string DepartmentName { get; set; } = string.Empty;

    public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
}
