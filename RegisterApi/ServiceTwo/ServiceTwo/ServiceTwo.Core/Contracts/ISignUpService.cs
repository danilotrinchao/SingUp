using ServiceTwo.Core.DTOs;
using ServiceTwo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTwo.Core.Contracts
{
    public interface ISignUpService
    {
        Task<UsuarioOutput> Register(UsuarioInput usuarioInput);
        Task<UsuariosParceiro> GetByUserId(int userId);
    }
}
