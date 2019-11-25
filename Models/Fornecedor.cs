using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fornecedores.Models
{
    public class Fornecedor
    {
        public int FornecedorId         { get; set; }

        [Required]
        public int EmpresaId { get; set; }

        public Empresa Empresa          { get; set; }

        [Required(ErrorMessage = "Digite o nome do fornecedor")]
        [MaxLength(255)]
        public string NomeFornecedor    { get; set; }

        [Required(ErrorMessage = "Digite o CPF/CNPJ do fornecedor")]
        [MaxLength(20)]
        public string CPF_CNPJ          { get; set; }

        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInclusao    { get; set; }
        public bool PessoaFisica        { get; set; }
        public List<Telefone> Telefones { get; set; }
    }

    public class FornecedorConsultaViewModel
    {
        public string NomeFornecedor { get; set; }
        public string CPF_CNPJ { get; set; }
        public string RG { get; set; }
        public DateTime DataInclusao { get; set; }
        public List<Telefone> Telefones { get; set; }

        public string GetTelefones()
        {
            var telefonesFormatados = "";

            foreach (var telefone in Telefones)
            {
                telefonesFormatados += telefone.NumeroTelefone.ToString() + "\n";
            }

            return telefonesFormatados;
        }
    }
}
