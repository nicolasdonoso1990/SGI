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
    public class UnidadesController : Controller
    {
        private InmobiliariaEntities db = new InmobiliariaEntities();

        // GET: /Unidades/
        public ActionResult Index()
        {
            var unidades = db.Unidades.Include(u => u.Propiedades);
            return View(unidades.ToList());
        }

        // GET: /Unidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unidad unidad = db.Unidades.Find(id);
            if (unidad == null)
            {
                return HttpNotFound();
            }
            return View(unidad);
        }

        // GET: /Unidades/Create
        public ActionResult Create()
        {
            ViewBag.cod_propiedad = new SelectList(db.Propiedades, "cod_propiedad", "ciudad");
            return View();
        }

        // POST: /Unidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="cod_unidad,cod_propiedad,m2,descripcion,estado")] Unidad unidad)
        {
            if (ModelState.IsValid)
            {
                db.Unidades.Add(unidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cod_propiedad = new SelectList(db.Propiedades, "cod_propiedad", "ciudad", unidad.cod_propiedad);
            return View(unidad);
        }

        // GET: /Unidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unidad unidad = db.Unidades.Find(id);
            if (unidad == null)
            {
                return HttpNotFound();
            }
            ViewBag.cod_propiedad = new SelectList(db.Propiedades, "cod_propiedad", "ciudad", unidad.cod_propiedad);
            return View(unidad);
        }

        // POST: /Unidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="cod_unidad,cod_propiedad,m2,descripcion,estado")] Unidad unidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cod_propiedad = new SelectList(db.Propiedades, "cod_propiedad", "ciudad", unidad.cod_propiedad);
            return View(unidad);
        }

        // GET: /Unidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unidad unidad = db.Unidades.Find(id);
            if (unidad == null)
            {
                return HttpNotFound();
            }
            return View(unidad);
        }

        // POST: /Unidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Unidad unidad = db.Unidades.Find(id);
            db.Unidades.Remove(unidad);
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
        public ActionResult SearchIndex(string searchString)
        {
            var unidades = from m in db.Unidades
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                unidades = unidades.Where(s => s.estado.Contains(searchString));
            }

            return View(unidades);
        }
    }
}
