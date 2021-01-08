using DataAcess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoQueTech.Controllers
{
    public class CategoriaFornecedorController : Controller
    {
        private readonly ICategoriaRepository _categoria;
        private readonly IFornecedoresRepository _fornecedor;

        public CategoriaFornecedorController(ICategoriaRepository categoria , IFornecedoresRepository fornecedores)
        {
            _categoria = categoria;
            _fornecedor = fornecedores;
        }
        public IActionResult Index(GeralVM geralVM)
        {

            if (geralVM.Categoria == null && geralVM.Fornecedor == null)
            {
                return View();
            }else if (geralVM.Categoria.CategoriaId == 0 || geralVM.Fornecedor.FornecedorId == 0)
            {
                if(geralVM.Categoria.Descricao != null)
                {
                    _categoria.Add(geralVM.Categoria);
                    _categoria.Save();
                }
                 if (geralVM.Fornecedor.Nome != null)
                {
                    _fornecedor.Add(geralVM.Fornecedor);
                    _fornecedor.Save();
                }
                else
                {
                  return View();
                }
                
            }

            return View();
        }
    }
}
