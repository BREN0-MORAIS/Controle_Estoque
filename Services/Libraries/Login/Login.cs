using DataAcess.Libraries.Session;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using DataAcess.Model;

namespace DataAcess.Libraries
{
    public class Login
    {
      

        public Login()
        {

        }

        public void LoginClient(Colaborador colaborador)
        {

            //Deserializando o Objeto pra a poder converter em string e armazenar na sessão
            var obj = JsonConvert.SerializeObject(colaborador);
            
            Sessao.Cadastrar(ConstsSession.KEY_COLABORADOR,obj);
        }

        public Colaborador Get()
        {
            
            string colaborador = Sessao.Get(ConstsSession.KEY_COLABORADOR);

            if (colaborador == null)
            {
                return null;
            }
            else
            {

            return JsonConvert.DeserializeObject<Colaborador>(colaborador);
            }
        }

        public void Logout()
        {
            Sessao.RemoveAll();
        }
    }
}
