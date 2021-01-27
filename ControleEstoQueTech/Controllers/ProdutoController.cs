using DataAcess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace ControleEstoQueTech
{
    public class ProdutoController : Controller
    {

        private readonly IProdutoRepository _produto;
        private readonly AppDataContext _context;
        private readonly IFornecedoresRepository _fornecedor;
        private readonly ICategoriaRepository _categoria;

        //private readonly UnitOfWork _unitOfWork;

        public ProdutoController(IProdutoRepository produto, AppDataContext context, ICategoriaRepository categoria, IFornecedoresRepository fornecedores)
        {
            _categoria = categoria;
            _produto = produto;
            _context = context;
            _fornecedor = fornecedores;

        }
        public IActionResult Index()
        {
           


            var obj = new GeralVM()
            {
                Produtos = _produto.GetAll(),
                Categorias =a
            };

            ViewBag.data = _produto.GetAll();
            ViewBag.dialogData = _produto.GetAll();


            return View(obj);
        }
        [HttpPost]
        public IActionResult UperSert(Produto produto)
        {
            if (produto.ProdutoId != 0)
            {
                _produto.Update(produto);
                _produto.Save();

            }
            else
            {
                _produto.Add(produto);
                _produto.Save();
            }


            return RedirectToAction("Index");
        }
        public IActionResult UperSert(int Id)
        {
            ViewBag.Fornecedor = _fornecedor.GetAll();
            ViewBag.Categorias = _categoria.GetAll();
         
            if (Id > 0)
            {
                Produto obj = _produto.Get(Id);
                return View(obj);
            }
            return View();
        }
        public IActionResult Excluir(Produto produto)
        {
          
            _produto.Save();
            return RedirectToAction("Index");
        }



        public IActionResult Edit(int id)
        {
            ViewBag.Fornecedor = _fornecedor.GetAll();
            ViewBag.Categorias = _categoria.GetAll();

            GeralVM obj = new GeralVM
            {
                Categorias = _context.Categorias,
                Produtos = _context.Produtos,
                Produto = _produto.Get(id),

            };

            return View(obj);
        }

        public IActionResult Info(int id)
        {
            return View(_produto.Get(id));
        }
        [HttpPost]
        public IActionResult Atualizar(Produto produto)
        {

            _produto.Update(produto);
            _produto.Save();


            return RedirectToAction("Index");
        }



    }
}
