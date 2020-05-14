using HousesPeru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace HousesPeru.services
{
    public interface IAuthService
    {
        void Login(Usuario usuario);
        void Logout();
        Usuario GetLogedUser();
    }
    public class AuthService : IAuthService
    {
        public Usuario GetLogedUser()
        {
            return (Usuario)HttpContext.Current.Session["Usuario"];
        }

        public void Login(Usuario usuario)
        {
            FormsAuthentication.SetAuthCookie(usuario.Email, false);
            HttpContext.Current.Session["Usuario"] = usuario;
        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
        }
        public struct User
        {
            public const string USUARIO = "usuario";
        }

    
    }


}