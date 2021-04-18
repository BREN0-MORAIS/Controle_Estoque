using DataAcess.Data.Repository;
using DataAcess.Libraries;
using DataAcess.Libraries.Session;
using DataAcess.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Estoque.Controllers
{
    public class ColaboradorController : Controller
    {
        private IColaboradorRepository _colaborador;
        private Login _login;

        public ColaboradorController(IColaboradorRepository colaborador, Login login)
        {
            _colaborador = colaborador;
            _login = login;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Colaborador colaborador)
        {

            var Logar = _colaborador.Login(colaborador);

            if (Logar != null)
            {
                _login.LoginClient(Logar);


                return Ok("Logado" +  Sessao.Get(ConstsSession.KEY_COLABORADOR));
            }
            else
            {
                return View();
            }
        }
    }
}
