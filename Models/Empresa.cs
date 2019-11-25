using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Fornecedores.Models
{
    public class Empresa
    {
        public int EmpresaId        { get; set; }

        [Required(ErrorMessage = "Selecione um estado")]
        public int EstadoId { get; set; }

        public Estado Estado { get; set; }

        [Required(ErrorMessage = "Insira o nome fantasia")]
        [MaxLength(255)]
        public string NomeFantasia  { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Insira o CNPJ da empresa")]
        [Remote(action: "ValidaEmpresa", controller: "Empresa", ErrorMessage = "CNPJ já cadastrado")]
        public string CNPJ          { get; set; }
    }
}
