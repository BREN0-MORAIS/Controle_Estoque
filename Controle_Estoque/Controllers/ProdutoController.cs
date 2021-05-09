using DataAcess.ViewModel;
using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using Microsoft.AspNetCore.Mvc;
using DataAcess.Data;
using DataAcess;

namespace Controle_Estoque.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produto { get; set; }

        public ICategoriaRepository _Categoria { get; set; }

        private IFornecedorRepository _fornecedor { get; set; }
        private ITipoUnitarioRepository _tipoUnitario { get; set; }

        public IEstoqueRepository _estoqueRepository { get; set; }

        public AppDataContext _db { get; set; }

        public ProdutoController(ICategoriaRepository categoria, AppDataContext db, IFornecedorRepository fornecedor, ITipoUnitarioRepository tipoUnitario, IProdutoRepository produto, IEstoqueRepository estoque)
        {
            _produto = produto;
            _Categoria = categoria;
            _fornecedor = fornecedor;
            _tipoUnitario = tipoUnitario;
            _estoqueRepository = estoque;
            _db = db;

        }
        public IActionResult Index()
        {
            var obj = new VMModalCadHome
            {
                ListCategorias = _Categoria.GetCategoriaList(),
                ListFornecedor = _fornecedor.GetDropDownList(),
                ListTipoUnitario = _tipoUnitario.GetDropDownList(),
                Categoria = new  Categoria(),
                Fornecedor = new Fornecedor(),
                Produto = new Produto(),
                TipoUnitario = new TipoUnitario()
            };

        
            return View(obj);
        }

        [HttpPost]
        public IActionResult CadastrarProduto(VMModalCadHome db)
        {

            if (ModelState.IsValid && db.Produto.EstoqueMaximo >= db.Produto.EstoqueMinimo)
            {
                _produto.Add(db.Produto);
                return RedirectToAction(nameof(Index));
            }
            else
            {

                return RedirectToAction(nameof(Index));
            }


        }

        public IActionResult CadastrarProduto()
        {


            return View();
        }
    }
}
