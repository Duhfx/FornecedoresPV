using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fornecedores.Models
{
    public class Telefone
    {
        public int TelefoneId           { get; set; }

        [Required(ErrorMessage = "Insira o número do telefone")]
        [MaxLength(20)]
        public string NumeroTelefone    { get; set; }
    }
}
