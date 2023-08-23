using EmployeeProjectTeam04.Model.Entity;
using EmployeeProjectTeam04.Shared.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EmployeeProjectTeam04.Infrastructure.Persistence.Configuration;
public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Departments");
        builder.HasKey(x => x.Id);
        builder.HasData(new
        {
            Id = 1,
            DepartmentName = "IT",
            Created = DateTimeOffset.Now,
            CreatedBy = "1",
            Status = EntityStatus.Created
        });
    }
}
