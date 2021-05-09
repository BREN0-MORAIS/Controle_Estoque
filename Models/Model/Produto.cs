using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual Fornecedor fornecedor { get; set; }
        public int FornecedorId { get; set; }
        public virtual TipoUnitario tipoUnitario { get; set; }
        public int TipoUnitarioId { get; set; }
        public int EstoqueMaximo { get; set; }
        public int EstoqueMinimo { get; set; }
        public virtual Categoria categoria { get; set; }
        public int CategoriaId { get; set; }
     

    }
}
