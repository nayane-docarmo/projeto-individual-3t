using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Domains
{
    public class Sala : BaseDomain
    {

        public int Andar { get; set; }
        public string Nome { get; set; }
        public float Metragem { get; set; }
    }
}