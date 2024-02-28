using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTwo.Core.Contracts
{
    public interface IUnitOfWork
    {
        IUsuarioRepository UsuarioRepository { get; }
    }
}
