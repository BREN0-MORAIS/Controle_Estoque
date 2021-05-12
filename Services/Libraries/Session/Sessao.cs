using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcess.Libraries.Session
{
    public  class Sessao
    {
        public static IHttpContextAccessor _Contexto { get; set; }
        private static HttpContextAccessor con = new HttpContextAccessor();
        public  Sessao(IHttpContextAccessor context)
        {
            _Contexto = context;
        }

        public static void Cadastrar(string key , string obj)
        {
            //setando na sessão  a key e string de objetos 
            con.HttpContext.Session.SetString(key, obj);
        }

        public static string Get(string key)
        {
            return con.HttpContext.Session.GetString(key);

        }
        public static void Remover(string key)
        {
            if(key != null)
            {
                con.HttpContext.Session.Remove(key);
            }
        }

        public static void RemoveAll()
        {
            con.HttpContext.Session.Clear();
        }
    }
}
