using ArjSys.Infraestrutura.Context;
using Microsoft.Extensions.DependencyInjection;

namespace ArjSys.Infraestrutura;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Adicione registros de serviços de infraestrutura aqui
        // Por exemplo:
        // services.AddScoped<IRepository, Repository>();

        return services;
    }
}
