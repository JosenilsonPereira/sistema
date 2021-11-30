using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.Controllers
{
    public class LoginController : Controller
    {
      private Contexto db = new Contexto();

        // GET: Login
        public ActionResult Index()
        {
            return PartialView();
        }


        [HttpPost]

        public ActionResult Login(Usuarios u)
        {

      
            // esta action trata o post (login)
            if (ModelState.IsValid) //verifica se é válido
            {

            
                using (Contexto db = new Contexto())
                {

                    var v = db.Usuarios.Where(a => a.NomeUsuario.Equals(u.NomeUsuario) && a.SenhaUsuario.Equals(u.SenhaUsuario)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["usuarioLogadoID"] = v.id.ToString();
                        Session["nomeUsuarioLogado"] = v.NomeUsuario.ToString();
                         return RedirectToAction("Index", "Home");
                      
                    }


                }
            }
            return PartialView("Index");

        }
    }
}