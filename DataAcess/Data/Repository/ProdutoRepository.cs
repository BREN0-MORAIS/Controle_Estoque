using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAcess
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDataContext _context;

       public ProdutoRepository(AppDataContext context)
        {
            _context = context;
        }
        public void Add(Produto entity)
        {
            _context.Add(entity);
            
        }

        public IEnumerable<Produto> GetAll()
        {
            IEnumerable<Produto> produto  = _context.Produtos.Include(a=> a.Fornecedor).Include(a=> a.Categoria).ToList();

            return produto;
        }
   
       public Produto Get(Produto produto)
        {
            Produto pro = GetId(produto);

            return pro;
            
        }

       public Produto GetId(Produto produto)
        {
            var buscar =_context.Produtos.Include("Fornecedor").Include("Categoria").First(a => a.ProdutoId == produto.ProdutoId );

            return buscar;
        }   
 

       public void Remove(Produto produto)
        {
           

            _context.Remove(GetId(produto));
        }
       
       public void Save()
        {
            _context.SaveChanges();
        }
       
       public void Delete(Produto entity)
        {
            throw new NotImplementedException();
        }
       
       
 
       
       public void Update(Produto entity)
        {
            _context.Update(entity);
        }
       
       public void Save(Produto entity)
        {
            throw new NotImplementedException();
        }
       
     
    }
}
