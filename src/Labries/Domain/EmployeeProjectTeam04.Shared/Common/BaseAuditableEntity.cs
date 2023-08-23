using EmployeeProjectTeam04.Shared.Enum;

namespace EmployeeProjectTeam04.Shared.Common;

public class BaseAuditableEntity
{
    public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;

    public string CreatedBy { get; set; } = string.Empty;

    public DateTimeOffset? LastModified { get; set; } 

    public string? LastModifiedBy { get; set;}

    public EntityStatus Status { get; set; }    

}