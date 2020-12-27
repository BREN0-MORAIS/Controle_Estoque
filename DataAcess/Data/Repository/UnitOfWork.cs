namespace DataAcess
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly AppDataContext _db;
        public UnitOfWork(AppDataContext db)
        {
            _db = db;
            Categoria = new CategoriaRepository(_db);
            Estoque = new EstoqueRepository(_db);
            Fornecedor = new FornecedoresRepository(_db);
            Produto = new ProdutoRepository(_db);
        }
        public ICategoriaRepository Categoria { get; }

        public IEstoqueRepository Estoque { get; }

        public IFornecedoresRepository Fornecedor { get; }

        public IProdutoRepository Produto { get; }

        public void Dispose()
        {
        }
    }
}
