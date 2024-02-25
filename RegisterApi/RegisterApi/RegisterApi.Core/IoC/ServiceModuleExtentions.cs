using Microsoft.Extensions.DependencyInjection;
using RegisterApi.Core.Contracts;
using RegisterApi.Core.Service;

namespace RegisterApi.Core.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();
        }
    }
}
