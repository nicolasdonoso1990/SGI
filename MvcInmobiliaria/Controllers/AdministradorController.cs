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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Administrador u)
        {
            // this action is for handle post (login)
            if (ModelState.IsValid) // this is check validity
            {
                using (InmobiliariaEntities dc = new InmobiliariaEntities())
                {
                    var v = dc.Administradores.Where(a => a.usuario.Equals(u.usuario) && a.contrasena.Equals(u.contrasena)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.usuario.ToString();
                        Session["LogedUserFullname"] = v.tipo.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                }
            }
            return View(u);
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