﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EmployeeProjectTeam04.Model.Entity;

namespace EmployeeProjectTeam04.Infrastructure.Persistence.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        builder.HasKey(e => e.Id);


        builder.HasOne(x => x.Country)
                     .WithMany(x => x.Employees)
                     .HasForeignKey(x => x.CountryId)
                     .IsRequired();

        builder.HasOne(x => x.State)
               .WithMany(x => x.Employees)
               .HasForeignKey(e => e.StateId)
               .IsRequired();

        builder.HasOne(x => x.City)
               .WithMany(x => x.Employees)
               .HasForeignKey(c => c.CityId)
               .IsRequired();

        builder.HasOne(x => x.Department)
               .WithMany(x => x.Employees)
               .HasForeignKey(d => d.DepartmentId)
               .IsRequired();
    }
}