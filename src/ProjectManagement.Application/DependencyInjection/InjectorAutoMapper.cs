using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProjectManagement.Application.DependencyInjection;

public static class InjectorAutoMapper
{
    public static IServiceCollection AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}
