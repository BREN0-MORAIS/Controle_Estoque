namespace DataAcess
{
    public interface IProdutoRepository : IRepository<Produto>
    {

         Produto Get(Produto entity);
    }
}
