using ExternalServiceApi.Core.Contracts;
using ExternalServiceApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalServiceApi.Core.Service
{
    public class RegisterService : IRegisterService
    {
        private readonly IUnitOfWork _uow;
        public RegisterService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<UsuariosParceiro> GetPreviousDataAsync(int userId)
        {
            var usuario = await _uow.UserDataRepository.GetByIdAsync(userId);
            return usuario;
        }

        public async Task<IEnumerable<UsuariosParceiro>> GetAll()
        {
            var usuarios = await _uow.UserDataRepository.GetAllAsync();
            return usuarios;
        }
    }
}
