using Microsoft.Extensions.DependencyInjection;
using ServiceTwo.Core.Contracts;
using ServiceTwo.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTwo.Infra.IoC
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
