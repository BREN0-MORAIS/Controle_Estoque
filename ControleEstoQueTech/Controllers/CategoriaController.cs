using DataAcess;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoQueTech.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoria;

        public CategoriaController(ICategoriaRepository categoria)
        {
            _categoria = categoria;
        }
        public IActionResult Index()
        {
            ViewBag.Categorias = _categoria.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarCategoria(Categoria categoria)
        {
            _categoria.Add(categoria);
            _categoria.Save();
            return View("Index");
        }
        public ActionResult Deletar()
        {
            return View(_categoria.GetAll());
        }

        public ActionResult Remover(Categoria categoria)
        {
            _categoria.Remove(categoria);
            _categoria.Save();

            return View("Index");
        }

     
    }
}
