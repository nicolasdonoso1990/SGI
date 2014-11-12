using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;

namespace MvcInmobiliaria.Controllers
{
    public class AdministradorController : Controller
    {
        //
        // GET: /Administrador/
       
        public ActionResult Login()
        {
            return View();
        }

        //POST: /Administrador/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Administrador b)
        {
            // this action is for handle post (login)
            if (ModelState.IsValid) // this is check validity
            {
                using (InmobiliariaEntities dc = new InmobiliariaEntities())
                {
                    var v = dc.Administradores.Where(a => a.usuario.Equals(b.usuario) && a.contrasena.Equals(b.contrasena)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.usuario.ToString();
                        Session["LogedUserFullname"] = v.estado.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                }
            }
            return View(b);
        }

        public ActionResult AfterLogin()
        {
            if (Session["LogedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
	}
}