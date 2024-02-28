using RegisterApi.Application.DTOs;
using RegisterApi.Application.Interfaces;
using RegisterApi.Core.Contracts;
using RegisterApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterApi.Core.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _uow;
        private readonly IServiceTwoIntegrationService _serviceTwoIntegrationService;
        public UsuarioService(IUnitOfWork uow, IServiceTwoIntegrationService serviceTwoIntegrationService)
        {
            _uow = uow;       
            _serviceTwoIntegrationService = serviceTwoIntegrationService;
        }
        public async Task<UsuarioOutput> CadastrarUsuario(UsuarioInput usuarioInput)
        {
            var usuario = new Usuario();
            var errors = new List<string>();
            if (usuarioInput != null)
            {
                usuario.Nome = usuarioInput.Nome;
                usuario.Sobrenome =  usuarioInput.Sobrenome;
                usuario.Email = usuarioInput.Email;
                usuario.Telefone = usuarioInput.Telefone;
                var res = await _uow.UsuarioRepository.AddAsync(usuario);
                if (res == null)
                {
                    errors.Add($"Falha ao registrar o usuário{usuario.Nome}");
                }
                else
                {
                    await _serviceTwoIntegrationService.IntegrateWithServiceTwo(usuarioInput);
                }
            }

            return new UsuarioOutput(!errors.Any(), errors);
        }

        public async Task<Usuario> GetByUserId(int userId)
        {
            var usuario = await _uow.UsuarioRepository.GetByIdAsync(userId);
            return usuario;
        }
    }
}
