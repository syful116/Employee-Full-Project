using EmployeeProjectTeam04.Shared.Common;

namespace EmployeeProjectTeam04.Services.Model;
public class VmEmployee : IVm
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Gender { get; set; }
    public int DepartmentId { get; set; }
    public VmDepartment? Department { get; set; }

    public DateTime Joiningdate { get; set; }
    public Boolean SSc { get; set; }
    public Boolean HSc { get; set; }
    public Boolean BSc { get; set; }
    public Boolean MSc { get; set; }
    public string? Picture { get; set; }

    public int CountryId { get; set; }
    public VmCountry? VmCountry { get; set; }

    public int StateId { get; set; }
    public VmState? VmState { get; set; }

    public int CityId { get; set; }
    public VmCity? VmCity { get; set; }
    public int Id { get; set; }
}
