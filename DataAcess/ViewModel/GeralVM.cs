using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
   public class GeralVM
    {
       public IEnumerable<Produto> Produtos { get; set; }
       public Produto Produto { get; set; }
       public IEnumerable<Categoria> Categorias { get; set; }
       public Categoria Categoria { get; set; }
       public Fornecedor Fornecedor { get; set; }
       public IEnumerable<Fornecedor> Fornecedores { get; set; }
    }
}
