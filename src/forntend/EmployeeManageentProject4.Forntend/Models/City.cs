using EmployeeProjectTeam04.Model.Entity;

namespace EmployeeManageentProject4.Forntend.Models
{
    public class City
    {
        public int id { get; set; }
        public string cityName { get; set; } = string.Empty;
        public int stateId { get; set; }
        public State states { get; set; }
    }
}
