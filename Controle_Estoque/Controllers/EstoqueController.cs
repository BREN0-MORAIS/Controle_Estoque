using DataAcess;
using DataAcess.Data.Repository.IRepository;
using DataAcess.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Estoque.Controllers
{
    public class EstoqueController : Controller
    {
        public IEstoqueRepository _estoque { get; set; }
        public EstoqueController(IEstoqueRepository estoque)
        {
            _estoque = estoque;
          
        }

   

        public IActionResult Index()
        {
            ViewBag.lista= _estoque.GetAll();

            return View();
        }
    }
}
