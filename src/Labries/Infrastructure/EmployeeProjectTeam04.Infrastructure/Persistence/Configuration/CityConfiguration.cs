using EmployeeProjectTeam04.Model.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EmployeeProjectTeam04.Infrastructure.Persistence.Configuration;
public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("Cities");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.States)
            .WithMany(x => x.Cities)
            .HasForeignKey(x => x.StateId)
            .IsRequired(true);
    }
}