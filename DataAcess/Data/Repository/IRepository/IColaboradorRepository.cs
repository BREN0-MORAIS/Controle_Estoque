using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Data.Repository
{
    public interface IColaboradorRepository : IRepository<Colaborador>
    {
        public Colaborador Login(Colaborador colaborador);
    }
}
