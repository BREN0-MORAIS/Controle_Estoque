using DataAcess.Libraries;
using DataAcess.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DataAcess.Data.Repository
{
    public class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
    {
        private AppDataContext _db { get; set; }

   
        public ColaboradorRepository(AppDataContext bd):base(bd)
        {
            _db = bd; 
            
        }


        public Colaborador Login(Colaborador colaborador)
        {
            if(colaborador != null)
            {
              return  _db.Colaboradores.FirstOrDefault(a=> a.Email == colaborador.Email && a.Senha == colaborador.Senha);
            }

            return null;
        }
    }
}
