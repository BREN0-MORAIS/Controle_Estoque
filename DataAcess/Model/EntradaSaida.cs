using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcess.Model
{
    public class EntradaSaida
    {
        public int Id { get; set; }
     
        public virtual Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int TotalValor { get; set; }

        //public TipoUnitario TipoUnitario { get; set; }
        //public int TipoUnitarioId { get; set; }
    
        //public Categoria Categoria { get; set; }
        //public int CategoriaId { get; set; }
      
        //public Fornecedor Fornecedor { get; set; } 
      
        //public int FornecedorId { get; set; }
    }
}
