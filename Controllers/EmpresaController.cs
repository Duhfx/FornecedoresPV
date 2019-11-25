using Fornecedores.Models;
using Fornecedores.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fornecedores.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly ICadastrosRepository _repository;

        public EmpresaController(ICadastrosRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult FormEmpresa()
        {
            ViewBag.Estados = _repository.GetEstados();
            return View();
        }

        [HttpPost]
        public IActionResult FormEmpresa(Empresa empresa)
        {
            ViewBag.Estados = _repository.GetEstados();

            if (ModelState.IsValid)
            {
                _repository.AdicionaEmpresa(empresa);

                ModelState.Clear();
                TempData["Mensagem"] = "Empresa cadastrada com sucesso";

                return View();
            }

            return View();
        }

        public IActionResult ValidaEmpresa(string CNPJ)
        {
            foreach (var empresa in _repository.GetEmpresas())
            {
                if (empresa.CNPJ == CNPJ)
                    return Json("CNPJ já cadastrado.");
            }

            return Json(true);
        }
    }
}
