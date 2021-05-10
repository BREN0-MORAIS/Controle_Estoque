using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess
{
    public interface IProdutoRepository : IRepository<Produto> { 


        IEnumerable<SelectListItem> GetDropDownList();

    }
}
