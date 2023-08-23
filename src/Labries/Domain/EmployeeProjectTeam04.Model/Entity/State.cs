using EmployeeProjectTeam04.Shared.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeProjectTeam04.Model.Entity;

public class State : BaseAuditableEntity, IEntity
{

	public int Id { get; set; }


    public string StateName { get; set; } = string.Empty;

    public int CountryId { get; set; }



    [ForeignKey("CountryId")]
    public  Country? Country { get; set; }

    public ICollection<City> Cities { get; set; } = new HashSet<City>();
    public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
}
