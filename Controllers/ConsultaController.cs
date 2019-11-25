using Fornecedores.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Fornecedores.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly ICadastrosRepository _repository;

        public ConsultaController(ICadastrosRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Consultar()
        {
            return View(_repository.GetEmpresas());
        }

        [HttpGet]
        public IActionResult ConsultaFornecedores(int id)
        {
            return View(_repository.GetFornecedorByEmpresa(id));
        }
    }
}
