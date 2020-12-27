using DataAcess;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoQueTech.Controllers
{
    public class SemCategoriaFornecedorController : Controller
    {
        private readonly IProdutoRepository _produto;

        public SemCategoriaFornecedorController(IProdutoRepository produto)
        {
            _produto = produto;

      
        }

        public IActionResult Index()
        {
            return View(_produto.GetAll());
        }
    }
}
