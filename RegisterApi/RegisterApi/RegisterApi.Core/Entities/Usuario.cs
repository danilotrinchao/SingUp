using RegisterApi.Application.Interfaces;
using RegisterApi.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterApi.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public Usuario(){}

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
