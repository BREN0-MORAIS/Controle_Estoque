using DataAcess.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAcess.ViewModel
{
    public class VMModalCadHome
    {
        //public Categoria   Categoria { get; set; }
        //public Fornecedor Fornecedor { get; set; }
        //public TipoUnitario TipoUnitario { get; set; }

        public Categoria Categoria { get; set; }
        public IEnumerable<SelectListItem> ListCategorias { get; set; }
        public IEnumerable<SelectListItem> ListFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public IEnumerable<SelectListItem> ListTipoUnitario { get; set; }
        public TipoUnitario TipoUnitario { get; set; }

        public Produto Produto { get; set; }
    }
}
