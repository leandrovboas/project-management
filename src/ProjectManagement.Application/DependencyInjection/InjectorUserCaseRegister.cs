using Microsoft.Extensions.DependencyInjection;
using ProjectManagement.Application.UseCases;
using ProjectManagement.Application.UseCases.Interface;

namespace ProjectManagement.API.Registers;

public class InjectorUserCaseRegister
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IGetUserUseCase, GetUserUseCase>();
    }
}
