using Microsoft.Extensions.DependencyInjection;
using ProjectManagement.Core.Repositories;
using ProjectManagement.Infra.Persistence;

namespace ProjectManagement.API.Registers;

public static class InjectorRepositoriesRegister
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
    }
}