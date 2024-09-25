using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ProjectManagement.API.Registers;

public static class InjectorSwaggerRegister
{
    public static void Register(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "Project Management",
                Description = "Api para o gerenciamente de projetos",
                Version = "v1",
                License = new OpenApiLicense() { Name = "MIT"}
            });

            var xmlFileName = $"{Assembly.GetExecutingAssembly().Location}.xml".Replace(".dll", "");
            c.IncludeXmlComments(xmlFileName);
        });
    }
}
