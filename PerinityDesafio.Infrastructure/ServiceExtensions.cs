using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PerinityDesafio.Domain.Interfaces;
using PerinityDesafio.Infrastructure.Context;
using PerinityDesafio.Infrastructure.Repositories;

namespace PerinityDesafio.Infrastructure;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
    {
        var ConnectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<DatabaseContext>(
            opt => opt.UseSqlServer(ConnectionString));

        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IDepartmentRepository, DepartmantRepository>();
        services.AddScoped<ITaskRepository, TaskRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
