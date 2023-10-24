using PerinityDesafio.API.Extensions;
using PerinityDesafio.Application.Services;
using PerinityDesafio.Infrastructure;
using PerinityDesafio.Infrastructure.Context;

namespace PerinityDesafio.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.ConfigurePersistenceApp(builder.Configuration);
        builder.Services.ConfigureApplicationApp();
        builder.Services.ConfigureCorsPolicy();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        CreateDatabase(app);

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }

    static void CreateDatabase(WebApplication app)
    {
        var serviceScope = app.Services.CreateScope();
        var dataContext = serviceScope.ServiceProvider.GetService<DatabaseContext>();
        dataContext?.Database.EnsureCreated();
    }
}