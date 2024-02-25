using Microsoft.Extensions.Configuration;
using RegisterApi.Core.Contracts;
using RegisterApi.Domain.Entities;

namespace RegisterApi.Infra.Data
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {
        }


    }
}
