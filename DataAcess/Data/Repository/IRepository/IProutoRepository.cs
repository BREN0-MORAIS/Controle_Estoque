using System.Collections.Generic;

namespace DataAcess
{
    public interface IProdutoRepository : IRepository<Produto>
    {
         void Update(int entity);
         Produto Get(Produto entity);
        IEnumerable<Produto> GetAll();
    }
}
