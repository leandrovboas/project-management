using Microsoft.EntityFrameworkCore;
using ProjectManagement.Infra;

namespace ProjectManagement.API.Registers;

public static class InjectorDbContentRegister
{
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }
}
