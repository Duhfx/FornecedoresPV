using Fornecedores.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fornecedores.Repository
{
    public class CadastrosRepository : ICadastrosRepository
    {
        private readonly ApplicationContext _applicationContext;

        public CadastrosRepository(ApplicationContext context)
        {
            _applicationContext = context;
        }

        public IList<Estado> GetEstados()
        {
            return _applicationContext.Estado.ToList();
        }

        public IList<Empresa> GetEmpresas()
        {
            return _applicationContext.Empresa.Include(e => e.Estado).ToList();
        }

        public IList<Fornecedor> GetFornecedores()
        {
            return _applicationContext.Fornecedor.ToList();
        }

        public IList<Fornecedor> GetFornecedorByEmpresa(int id)
        {
            return _applicationContext.Fornecedor.Include(f => f.Telefones).Where(f => f.EmpresaId == id).ToList();
        }

        public Estado GetEstadoByID(int id)
        {
            return _applicationContext.Estado.Find(id);
        }

        public Estado GetEstadoDaEmpresa(int idEmpresa)
        {
            return _applicationContext.Empresa
                                      .Include(e => e.Estado)
                                      .Where(e => e.EmpresaId == idEmpresa)
                                      .FirstOrDefault()
                                      .Estado;
        }

        public void AdicionaEmpresa(Empresa novaEmpresa)
        {
            _applicationContext.Empresa.Add(novaEmpresa);
            _applicationContext.SaveChanges();
        }


        public void AdicionaFornecedor(Fornecedor novoFornecedor)
        {
            _applicationContext.Fornecedor.Add(novoFornecedor);
            _applicationContext.SaveChanges();
        }
    }
}
