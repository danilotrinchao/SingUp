using ServiceTwo.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTwo.Core.Entities
{
    public class UsuariosParceiro: EntityBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime? Dt_Alteracao { get; set; }
    }
}
