using DataAcess.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Data.Repository.IRepository
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        IEnumerable<SelectListItem> GetDropDownList();
    }
}
