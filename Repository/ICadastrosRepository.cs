using System.Collections.Generic;
using Fornecedores.Models;

namespace Fornecedores.Repository
{
    public interface ICadastrosRepository
    {
        void AdicionaEmpresa(Empresa novaEmpresa);
        void AdicionaFornecedor(Fornecedor novoFornecedor);
        IList<Empresa> GetEmpresas();
        Estado GetEstadoByID(int id);
        Estado GetEstadoDaEmpresa(int idEmpresa);
        IList<Estado> GetEstados();
        IList<Fornecedor> GetFornecedorByEmpresa(int id);
        IList<Fornecedor> GetFornecedores();
    }
}