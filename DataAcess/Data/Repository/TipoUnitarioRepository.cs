using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcess.Data.Repository
{
    public class TipoUnitarioRepository : Repository<TipoUnitario> , ITipoUnitarioRepository
    {
        public  AppDataContext _repo { get; set; }
        public TipoUnitarioRepository(AppDataContext option , AppDataContext repo ):base(option)
        {
            _repo = repo;
        }
        public IEnumerable<SelectListItem> GetDropDownList()
        {
            return _repo.TipoUnitarios.Select(i => new SelectListItem()
            {
                Text = i.Nome,
                Value = i.Id.ToString()
            });
        }

    }
}
