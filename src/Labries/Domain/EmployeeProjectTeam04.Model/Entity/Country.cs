using EmployeeProjectTeam04.Shared.Common;

namespace EmployeeProjectTeam04.Model.Entity
{
    public class Country : BaseAuditableEntity, IEntity
    {
        public int Id { get; set; }

        public string CountryName { get; set; } = string.Empty;

        public ICollection<State> States { get; set; } = new HashSet<State>();
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
