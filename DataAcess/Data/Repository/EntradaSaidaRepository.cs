using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcess.Data.Repository
{
    public class EntradaSaidaRepository : Repository<EntradaSaida>, IEntradaSaidaRepository
    {
        public AppDataContext _repo { get; set; }

        public EntradaSaidaRepository(AppDataContext option, AppDataContext repo) : base(option)
        {
            _repo = repo;
        }


      
    }
}
