using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Domains
{
    public class Sala : BaseDomain
    {
        [Required]
        public int Andar { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public float Metragem { get; set; }
    }
}