using ProjectManagement.API.Registers;
using ProjectManagement.Application.DependencyInjection;

namespace ProjectManagement.API.Extensiond;

public static class DependecyInjectionsExtensions
{
    public static void AddDependencyInjection (this IServiceCollection services, IConfiguration configuration)
    {
        InjectorDbContentRegister.RegisterServices(services, configuration);
        InjectorSwaggerRegister.Register(services);
        InjectorRepositoriesRegister.RegisterServices(services);
        InjectorUserCaseRegister.RegisterServices(services);
        InjectorAutoMapper.AddAutoMapper(services);

    }
}
