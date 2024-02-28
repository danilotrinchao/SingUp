using ServiceTwo.Core.Contracts;
using ServiceTwo.Core.DTOs;
using ServiceTwo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTwo.Core.Service
{
    public class SignUpService: ISignUpService
    {
        private readonly IUnitOfWork _uow;
        public SignUpService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<UsuariosParceiro> GetByUserId(int userId)
        {
            var usuario = await _uow.UsuarioRepository.GetByIdAsync(userId);
            return usuario;
        }

        public async Task<UsuarioOutput> Register(UsuarioInput usuarioInput)
        {
            var usuario = new UsuariosParceiro();
            var errors = new List<string>();
            if (usuarioInput != null)
            {
                usuario.Nome = usuarioInput.Nome;
                usuario.Sobrenome = usuarioInput.Sobrenome;
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
