using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcess.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        private readonly AppDataContext _db;
        public AppDataContext _repo { get; set; }

        public ProdutoRepository(AppDataContext option, AppDataContext repo) : base(option)
        {
            _repo = repo;
        }

      

        public IEnumerable<SelectListItem> GetDropDownList()
        {
            return _repo.Produtos.Select(i => new SelectListItem()
            {
                Text = i.Nome,
                Value = i.Id.ToString()
            });
        }
   
   
    }
}
