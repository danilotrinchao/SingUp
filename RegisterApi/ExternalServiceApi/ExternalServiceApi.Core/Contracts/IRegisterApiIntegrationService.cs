using ExternalServiceApi.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalServiceApi.Core.Contracts
{
    public interface IRegisterApiIntegrationService
    {
        Task<DadosInput> GetUserData(int userId);
    }
}
