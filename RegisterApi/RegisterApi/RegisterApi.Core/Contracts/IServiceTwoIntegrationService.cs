using RegisterApi.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterApi.Core.Contracts
{
    public interface IServiceTwoIntegrationService
    {
        Task<bool> IntegrateWithServiceTwo(UsuarioInput usuarioInput);
    }
}
