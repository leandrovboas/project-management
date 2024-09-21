using ProjectManagement.API.Registers;

namespace ProjectManagement.API.Extensiond;

public static class DependecyInjectionsExtensions
{
    public static void AddDependencyInjection (this IServiceCollection services, IConfiguration configuration)
    {
        InjectorDbContentRegister.RegisterServices(services, configuration);
        InjectorSwaggerRegister.Register(services);

    }
}
