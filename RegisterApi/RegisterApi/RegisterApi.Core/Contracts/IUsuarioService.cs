﻿using RegisterApi.Application.DTOs;
using RegisterApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterApi.Core.Contracts
{
    public interface IUsuarioService
    {
        Task<UsuarioOutput> CadastrarUsuario(UsuarioInput usuarioInput);
        Task<Usuario> GetByUserId(int userId);
    }
}
