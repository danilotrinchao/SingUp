using Microsoft.Extensions.DependencyInjection;
using ServiceTwo.Core.Contracts;
using ServiceTwo.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTwo.Core.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISignUpService, SignUpService>();
        }
    }
}
