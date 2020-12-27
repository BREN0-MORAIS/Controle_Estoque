using System;

namespace DataAcess
{
    interface IUnitOfWork :IDisposable
    {
         ICategoriaRepository Categoria { get;  }
         IEstoqueRepository Estoque { get;  }
         IFornecedoresRepository Fornecedor { get; }
         IProdutoRepository Produto { get;  }
  
    }
}
