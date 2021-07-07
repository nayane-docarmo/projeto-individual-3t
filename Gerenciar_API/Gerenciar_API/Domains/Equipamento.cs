using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Domains
{
    public class Equipamento : BaseDomain
    { 
        public string Marca { get; set; }
        public int NSerie { get; set; }
        public int NPatrimonio { get; set; }
        public string Tipo { get; set; }
        public bool Disponivel { get; set; }
        public string Descricao { get; set; }
    }
}
