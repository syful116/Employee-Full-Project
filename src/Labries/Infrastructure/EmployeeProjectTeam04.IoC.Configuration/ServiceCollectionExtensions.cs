using EmployeeProjectTeam04.Core;
using EmployeeProjectTeam04.Core.Mapper;
using EmployeeProjectTeam04.Infrastructure.DatabaseContext;
using EmployeeProjectTeam04.Repositories.Base;
using EmployeeProjectTeam04.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeProjectTeam04.IoC.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection MapCore(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EmploymentDbContext>(optins => optins.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddAutoMapper(typeof(CommonMapper).Assembly);
        services.AddTransient<ICountryRepository, CountryRepository>();
        services.AddTransient<IStateRepository, StateRepository>();
        services.AddTransient<ICityRepository, CityRepository>();
        services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        services.AddTransient<IDepartmentRepositpry, DepartmentRepository>();
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(typeof(ICore).Assembly);

        });
        return services;
    }
}