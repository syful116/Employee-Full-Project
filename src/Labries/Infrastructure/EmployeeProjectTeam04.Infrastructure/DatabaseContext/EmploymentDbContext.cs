using Microsoft.EntityFrameworkCore;

namespace EmployeeProjectTeam04.Infrastructure.DatabaseContext;

public class EmploymentDbContext : DbContext
{
    public EmploymentDbContext(DbContextOptions<EmploymentDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmploymentDbContext).Assembly);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}