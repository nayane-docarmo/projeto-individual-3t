using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Domains
{
    public class Usuario : BaseDomain
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Setor { get; set; }
        public string Senha { get; set; }
    }
}
