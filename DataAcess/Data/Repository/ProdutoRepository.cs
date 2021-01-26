using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAcess
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        private readonly AppDataContext _db;

        public ProdutoRepository(AppDataContext db) : base(db)
        {
            this._db = db;
        }

        public void Update(int entity)
        {
            throw new NotImplementedException();
        }

        public Produto Get(int id)
        {
            return _db.Produtos.First(a => a.ProdutoId == id);
        }

        //public IEnumerable<Produto> GetAll(Expression<Func<Produto, bool>> a )
        //{
        //    var obj = _db.Produtos.Where(a).ToList();

        //    return obj;
        //}
        // public void Add(Produto entity)
        // {
        //     _context.Add(entity);

        // }

        // public IEnumerable<Produto> GetAll()
        // {
        //     IEnumerable<Produto> produto  = _context.Produtos.Include("Fornecedor").Include("Categoria").ToList();

        //     return produto;
        // }

        //public Produto Get(Produto produto)
        // {
        //     Produto pro = GetId(produto);

        //     return pro;

        // }

        //public Produto GetId(Produto produto)
        // {
        //     var buscar =_context.Produtos.Include("Fornecedor").Include("Categoria").First(a => a.ProdutoId == produto.ProdutoId );

        //     return buscar;
        // }   


        //public void Remove(Produto produto)
        // {


        //     _context.Remove(GetId(produto));
        // }

        //public void Save()
        // {
        //     _context.SaveChanges();
        // }

        //public void Delete(Produto entity)
        // {
        //     throw new NotImplementedException();
        // }




        //public void Update(Produto entity)
        // {
        //     _context.Update(entity);
        // }
        // public Produto GetId(int produto)
        // {
        //     var buscar = _context.Produtos.Include("Fornecedor").Include("Categoria").First(a => a.ProdutoId == produto);

        //     return buscar;
        // }
        // public void Update(int entity)
        // {
        //     _context.Update(GetId(entity));
        // }


        // public void Save(Produto entity)
        // {
        //     _context.SaveChanges();
        // }


    }
}
