using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public  static class Validar
    {
        public static object VerificarExeption(object obj)
        {
            try
            {
                return obj;
            }
            catch (Exception e)
            {
                return e;
            } 
        }
      

    }
}
