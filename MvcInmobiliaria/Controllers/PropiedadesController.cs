using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entidades;

namespace MvcInmobiliaria.Controllers
{
    public class PropiedadesController : Controller
    {
        private InmobiliariaEntities db = new InmobiliariaEntities();

        // GET: /Propiedades/
        public ActionResult Index()
        {
            return View(db.Propiedades.ToList());
        }

        // GET: /Propiedades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propiedad propiedad = db.Propiedades.Find(id);
            if (propiedad == null)
            {
                return HttpNotFound();
            }
            return View(propiedad);
        }

        // GET: /Propiedades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Propiedades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="cod_propiedad,ciudad,direccion,m2,descripcion,estado")] Propiedad propiedad)
        {
            if (ModelState.IsValid)
            {
                db.Propiedades.Add(propiedad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propiedad);
        }

        // GET: /Propiedades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propiedad propiedad = db.Propiedades.Find(id);
            if (propiedad == null)
            {
                return HttpNotFound();
            }
            return View(propiedad);
        }

        // POST: /Propiedades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="cod_propiedad,ciudad,direccion,m2,descripcion,estado")] Propiedad propiedad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propiedad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propiedad);
        }

        // GET: /Propiedades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propiedad propiedad = db.Propiedades.Find(id);
            if (propiedad == null)
            {
                return HttpNotFound();
            }
            return View(propiedad);
        }

        // POST: /Propiedades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Propiedad propiedad = db.Propiedades.Find(id);
            db.Propiedades.Remove(propiedad);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Buscar(string stringBusqueda)
        {
            var propiedades = from m in db.Propiedades
                             select m;

            if (!String.IsNullOrEmpty(stringBusqueda))
            {

                propiedades = propiedades.Where(s => s.direccion.Contains(stringBusqueda));

            }
            return View(propiedades);

        }

    }
}
