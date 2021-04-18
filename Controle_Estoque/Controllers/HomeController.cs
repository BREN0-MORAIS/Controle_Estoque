using Controle_Estoque.Models;
using DataAcess.Data.Repository;
using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Estoque.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICategoriaRepository _categoria;
        private readonly IFornecedorRepository _fornecedor;
        private readonly ITipoUnitarioRepository _tipoUnitario;

        public HomeController(ICategoriaRepository categoria, IFornecedorRepository fornecedor, ITipoUnitarioRepository tipoUnitario)
        {
            _categoria = categoria;
            _fornecedor = fornecedor;
            _tipoUnitario = tipoUnitario;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Categoria(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoria.Add(categoria);


                return RedirectToAction("Index");
                TempData["M_Sucess"] = "Sucesso ao Salvar Categoria";
            }
            else
            {


                return RedirectToAction("Index");
                TempData["M_Error"] = "Não foi possivel Cadastrar Categoria";
            }

        }

        public IActionResult Fornecedor([FromForm] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {

                _fornecedor.Add(fornecedor);
                TempData["M_Sucess"] = "Sucesso ao Salvar Fornecedor";
                return RedirectToAction(nameof(Index));
            }
            else
            {

                return RedirectToAction(nameof(Index));
                TempData["M_Error"] = "Não foi possivel Cadastrar Fornecedor";
            }

        }

        public IActionResult TipoUnitario([FromForm] TipoUnitario tipoUnitario)
        {
            if (ModelState.IsValid)
            {
                _tipoUnitario.Add(tipoUnitario);
                        
                TempData["M_Sucess"] = "Tipo Unitário Cadastrado com sucesso";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["M_Error"] = "Não foi possivel Cadastrar Tipo Unitário";
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
