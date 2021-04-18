using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Data.Repository
{
    public class EntradaSaidaRepository : Repository<EntradaSaida>, IEntradaSaidaRepository
    {

        public EntradaSaidaRepository(AppDataContext option) : base(option)
        {

        }
    }
}
