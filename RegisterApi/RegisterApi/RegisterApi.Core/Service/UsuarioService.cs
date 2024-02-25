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
        public UsuarioService(IUnitOfWork uow)
        {
            _uow = uow;       
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
            }

            return new UsuarioOutput(!errors.Any(), errors);
        }
    }
}
