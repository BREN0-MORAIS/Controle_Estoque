﻿using DataAcess;
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
        private IEstoqueRepository _repoEstoque { get; set; }

        public EntradaSaidaController(IProdutoRepository repoProduto, IEntradaSaidaRepository repoEntradaSaida, IEstoqueRepository repoEstoque)
        {
            _repoProduto = repoProduto;
            _repoEntradaSaida = repoEntradaSaida;
            _repoEstoque = repoEstoque;
        }

        public IActionResult Index()
        {
            var obj = new VMModalCadHome
            {
                ListProduto = _repoProduto.GetDropDownList(),
                EntradaSaida = new EntradaSaida(),
                Produto = new Produto(),
            };

            return View(obj);
        }
        public IActionResult Cadastrar(EntradaSaida entradaSaida)
        {

            _repoEntradaSaida.Add(entradaSaida);
          
            var qtdEstoque = _repoEstoque.Get(a => a.ProdutoId == entradaSaida.ProdutoId);

            if(qtdEstoque == null)
            {
                var objEstoque = new Estoque
                {
                    ProdutoId = entradaSaida.ProdutoId,
                    QuantidadeEstoque = entradaSaida.Quantidade
                };

                _repoEstoque.Add(objEstoque);
            }else if (entradaSaida.Tipo == "ENTRADA")
            {
                var objEstoque = new Estoque
                {
                    ProdutoId = entradaSaida.ProdutoId,
                    QuantidadeEstoque = qtdEstoque.QuantidadeEstoque + entradaSaida.Quantidade
                };
            }
            else
            {
                var objEstoque = new Estoque
                {
                    Id =  qtdEstoque.Id,
                    ProdutoId = entradaSaida.ProdutoId,
                    QuantidadeEstoque = qtdEstoque.QuantidadeEstoque - entradaSaida.Quantidade
                };

                _repoEstoque.Update(objEstoque);
            }
            return RedirectToAction("Index", "Estoque");
        }
    }
}
