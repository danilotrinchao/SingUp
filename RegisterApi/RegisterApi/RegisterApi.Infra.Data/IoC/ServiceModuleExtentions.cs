using Microsoft.Extensions.DependencyInjection;
using RegisterApi.Core.Contracts;
using RegisterApi.Infra.Data;

namespace RegisterApi.Infrastructure.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddTransient<IUsuarioRepository, UsuarioRepository>();

        }
    }
}
