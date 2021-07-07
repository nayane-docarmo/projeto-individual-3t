using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Domains
{
    public class Usuario : BaseDomain
    {
            [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string Nome { get; set; }

            [Required(ErrorMessage = "O CPF do usuário é obrigatório")]
            [RegularExpression(@"[^A-Z][^a-z]")]
            [StringLength(11,MinimumLength = 11, ErrorMessage = "O CPF tem que conter 11 Números")]
        public string CPF { get; set; }

            [Required(ErrorMessage = "O Setor do usuário é obrigatório")]
        public string Setor { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [StringLength(10, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 10 caracteres")]
            [Display(Name = "Senha")]
            [RegularExpression(@"^[a-zA-Z][0-9A-Za-z@!#$%¨&*()_><?/}{§|\.]*\d+[0-9A-Za-z@!#$%¨&*()_><?/}{§|\.]*$", ErrorMessage = "Senha fora do Padrão.")]
        public string Senha { get; set; }
    }
}
