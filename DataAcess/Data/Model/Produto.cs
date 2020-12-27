namespace DataAcess
{
    public class Produto
    {
        private AppDataContext db;

        public Produto() { }
        public Produto(AppDataContext db)
        {
            this.db = db;
        }

        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public int FornecedorId { get; set; }
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }
 
    }
}
