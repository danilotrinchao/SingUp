using ExternalServiceApi.Core.DTOs;
using ExternalServiceApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalServiceApi.Core.Contracts
{
    public interface IServiceTwoIntegrationService
    {
        Task<DadosInput> GetUserData(int userId);
    }
}
