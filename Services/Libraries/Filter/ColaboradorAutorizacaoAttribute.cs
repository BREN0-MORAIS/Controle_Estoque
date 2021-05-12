using DataAcess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Libraries.Filter
{
    public class ColaboradorAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        Login _login;
     
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _login = (Login)context.HttpContext.RequestServices.GetService(typeof(Login));

            Colaborador categoria = _login.Get();

            if(categoria == null)
            {
                context.Result = new ContentResult() { Content = "Acesso Negado" };
            }
        }
    }
}
