using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterApi.Application.DTOs
{
    public class UsuarioInput
    {
        public UsuarioInput(){}
        public UsuarioInput(string nome, string sobrenome, string email, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Telefone = telefone;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
