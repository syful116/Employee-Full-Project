using EmployeeProjectTeam04.Shared.Common;
using System.Text.Json.Serialization;

namespace EmployeeProjectTeam04.Services.Model;

public class VmState : IVm
{
    public int Id { get; set; }
    public string? StateName { get; set; }
    public int CountryId { get; set; }
    [JsonIgnore]
    public VmCountry? Country { get; set; }



}