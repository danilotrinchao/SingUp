using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceTwo.Core.Contracts;


namespace ServiceTwo.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IServiceProvider _serviceProvider;

        public UnitOfWork(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            _serviceProvider = serviceProvider;
        }

        public IUsuarioRepository UsuarioRepository => _serviceProvider.GetService<IUsuarioRepository>();
    }
}
