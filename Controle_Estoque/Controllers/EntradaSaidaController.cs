using DataAcess;
using DataAcess.Data.Repository.IRepository;
using DataAcess.Libraries.Filter;
using DataAcess.Model;
using DataAcess.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Estoque.Controllers
{
    public class EntradaSaidaController : Controller
    {
        private IProdutoRepository _repoProduto { get; set; }
        private IEntradaSaidaRepository _repoEntradaSaida { get; set; }
      
        public EntradaSaidaController(IProdutoRepository repoProduto, IEntradaSaidaRepository repoEntradaSaida)
        {
            _repoProduto = repoProduto;
            _repoEntradaSaida = repoEntradaSaida;
        }

        public IActionResult Index()
        {
            var obj = new VMModalCadHome
            {
                ListProduto = _repoProduto.GetDropDownList(),
                EntradaSaida = new EntradaSaida(),
                Produto= new Produto(),
            };

            return View(obj);
        } 
        public IActionResult Cadastrar(EntradaSaida entradaSaida)
        {
           
            _repoEntradaSaida.Add(entradaSaida);


            return RedirectToAction("Index", "Estoque");
        }
    }
}
