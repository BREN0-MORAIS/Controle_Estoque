using DataAcess.Libraries.Filter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Estoque.Controllers
{
    public class EntradaSaidaController : Controller
    {
       //[ColaboradorAutorizacao]
        public IActionResult Index()
        {
            return View();
        }
    }
}
