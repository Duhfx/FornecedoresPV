using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fornecedores.Models
{
    public class Estado
    {
        public int EstadoId            { get; set; }
       
        [Required]
        [MaxLength(2)]
        public string SiglaEstado      { get; set; }
       
        [Required]
        [MaxLength(30)]
        public string DescricaoEstado  { get; set; }
    }
}
