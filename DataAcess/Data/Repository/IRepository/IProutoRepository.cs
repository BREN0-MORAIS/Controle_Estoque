using System.Collections.Generic;

namespace DataAcess
{
    public interface IProdutoRepository : IRepository<Produto>
    {
         void Update(int entity);

        Produto Get(int id);


        IEnumerable<Produto> GetAll();
    }
}
