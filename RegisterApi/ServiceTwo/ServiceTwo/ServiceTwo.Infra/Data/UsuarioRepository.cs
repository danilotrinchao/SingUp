using Microsoft.Extensions.Configuration;
using ServiceTwo.Core.Contracts;
using ServiceTwo.Core.Entities;

namespace ServiceTwo.Infra.Data
{
    public class UsuarioRepository : RepositoryBase<UsuariosParceiro>, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration){}


    }
}
