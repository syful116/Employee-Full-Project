using EmployeeProjectTeam04.Shared.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeProjectTeam04.Model.Entity;

public class City: BaseAuditableEntity, IEntity

{
    public int Id { get; set; }
    public string CityName { get; set; } = string.Empty;
    public int StateId { get; set; }
    public State? States { get; set; }
    public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

}
