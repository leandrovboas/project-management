using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagement.Infra.Configurations;

namespace ProjectManagement.API.Registers;

public static class InjectorDbContentRegister
{
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["ConnectionString:Portgresql"] 
            ?? throw new Exception("Falta a ConnectionString no appsettings.json");
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(connectionString));
    }
}
