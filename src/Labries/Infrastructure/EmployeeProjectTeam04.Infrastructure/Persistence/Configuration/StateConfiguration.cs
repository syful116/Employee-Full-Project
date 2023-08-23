using EmployeeProjectTeam04.Model.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EmployeeProjectTeam04.Infrastructure.Persistence.Configuration;

public class StateConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("States");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Country)
     .WithMany(x => x.States)
     .HasForeignKey(x => x.CountryId)
     .IsRequired(true);
    }
}