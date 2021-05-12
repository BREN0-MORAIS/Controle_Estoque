using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Model
{
    public class Estoque
    {
        public int Id { get; set; }
        public virtual Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int QuantidadeEstoque { get; set; }

    }
}
