using Microsoft.Extensions.DependencyInjection;

namespace ArjSys.Aplicacao;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Adicione registros de serviços da aplicação aqui
        // Por exemplo:
        // services.AddScoped<IService, Service>();

        return services;
    }
}
