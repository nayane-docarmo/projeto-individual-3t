using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Domains
{
    public class Equipamento : BaseDomain
    { 
            [Required]
            [Display(Name = "Marca do Equipamento")]
        public string Marca { get; set; }

            [Required]
            [Display(Name = "Número da Série")]
        public int NSerie { get; set; }

            [Required]
            [Display(Name = "Número do Patrimônio")]
        public int NPatrimonio { get; set; }

            [Required]
            [Display(Name = "Tipo do Equipamento")]
        public string Tipo { get; set; }

            [Required]
        public bool Disponivel { get; set; }

        public string Descricao { get; set; }
    }
}
