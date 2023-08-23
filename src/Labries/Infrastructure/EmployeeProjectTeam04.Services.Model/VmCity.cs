using EmployeeProjectTeam04.Shared.Common;
using System.Text.Json.Serialization;

namespace EmployeeProjectTeam04.Services.Model;

public class VmCity : IVm
{
    public int Id { get; set; }
    public string? CityName { get; set; }
    public int StateId { get; set; }
    [JsonIgnore]
    public VmState? State { get; set; }
    [JsonIgnore]
    public ICollection<VmEmployee> VmEmployees { get; set; } = new HashSet<VmEmployee>();
}