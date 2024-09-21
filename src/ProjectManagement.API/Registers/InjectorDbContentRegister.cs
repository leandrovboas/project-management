using Microsoft.EntityFrameworkCore;
using ProjectManagement.Infra.Configurations;

namespace ProjectManagement.API.Registers;

public static class InjectorDbContentRegister
{
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["ConnectionString:Portgresql"];
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(connectionString));
    }
}
