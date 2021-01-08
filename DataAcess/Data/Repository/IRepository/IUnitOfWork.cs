using System;

namespace DataAcess
{
    interface IUnitOfWork :IDisposable
    {
         ICategoriaRepository Categoria { get;  }
  
         IFornecedoresRepository Fornecedor { get; }
         IProdutoRepository Produto { get;  }
  
    }
}
