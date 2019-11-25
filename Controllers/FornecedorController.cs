using Fornecedores.Models;
using Fornecedores.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Fornecedores.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly ICadastrosRepository _repository;

        public FornecedorController(ICadastrosRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult FormFornecedor()
        {
            ViewBag.Empresas = _repository.GetEmpresas();
            return View();
        }

        [HttpPost]
        public IActionResult FormFornecedor(Fornecedor fornecedor, int TipoPessoa)
        {
            ViewBag.Empresas = _repository.GetEmpresas();

            if (ModelState.IsValid)
            {
                //A posição 0 é a div default que é utilizada para compor os campos dinâmicos do telefone
                if (fornecedor.Telefones != null)
                    fornecedor.Telefones.RemoveAt(0);

                fornecedor.PessoaFisica = TipoPessoa == 1;
                fornecedor.DataInclusao = DateTime.Now;

                if (fornecedor.PessoaFisica)
                {
                    if (_repository.GetEstadoDaEmpresa(fornecedor.EmpresaId).SiglaEstado == "PR" && GetIdade(fornecedor.DataNascimento) < 18)
                    {
                        ViewBag.ViewModel = new ErrorViewModel() { Mensagem = "Não é permitido cadastro de fornecedor menor de idade para empresas do PR." };
                        return View();
                    } 
                    else if (String.IsNullOrEmpty(fornecedor.RG) || fornecedor.DataNascimento == null)
                    {
                        ViewBag.ViewModel = new ErrorViewModel() { Mensagem = $"Para fornecedor pessoa física é necessário informar {(String.IsNullOrEmpty(fornecedor.RG) ? "RG" : "Data de Nascimento")}" };
                        return View();
                    }
                }

                _repository.AdicionaFornecedor(fornecedor);

                ModelState.Clear();
                TempData["Mensagem"] = "Fornecedor cadastrado com sucesso";

                return View();
            }
            else
                ViewBag.ViewModel = new ErrorViewModel() { Mensagem = $"Não foi possível cadastrar o fornecedor." };

            return View();
        }

        private int GetIdade(DateTime dataNascimento)
        {
            return DateTime.Today.Year - dataNascimento.Year;
        }
    }
}
