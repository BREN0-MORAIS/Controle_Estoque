using System.ComponentModel.DataAnnotations;

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

        [Display(Name ="Código")]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name ="Nome")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        [Required]
        public int? CategoriaId { get; set; }
        [Required]
        public int? FornecedorId { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int? Quantidade { get; set; }
        public int? Status { get; set; }
        public int Estoque { get; set; }

    }
}
