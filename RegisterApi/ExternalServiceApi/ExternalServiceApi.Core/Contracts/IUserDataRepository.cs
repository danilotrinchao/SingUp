using ExternalServiceApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalServiceApi.Core.Contracts
{
    public interface IUserDataRepository : IRepository<UsuariosParceiro>
    {
        //public  Task<UsuariosParceiro> GetById(int userId);
        //public Task<IEnumerable<UsuariosParceiro>> GetAll();
    }
}
