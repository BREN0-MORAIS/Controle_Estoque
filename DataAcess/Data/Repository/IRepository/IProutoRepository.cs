using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAcess
{
    public interface IProdutoRepository : IRepository<Produto>
    {
         void Update(int entity);

        Produto Get(int id);

        IEnumerable<Produto> GetAll(Expression<Func<Produto,bool>> a);
    }
}
