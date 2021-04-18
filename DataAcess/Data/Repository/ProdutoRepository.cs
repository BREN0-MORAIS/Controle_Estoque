using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        private readonly AppDataContext _db;
        public ProdutoRepository(AppDataContext option) : base(option){
        
        
        }


      
    }
}
