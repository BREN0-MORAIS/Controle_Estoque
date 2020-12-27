namespace DataAcess
{
    public interface IFornecedoresRepository : IRepository<Fornecedor>
    {
         Estoque Get(Fornecedor entity);
    }
}
