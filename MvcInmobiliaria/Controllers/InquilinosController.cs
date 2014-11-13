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
    public class InquilinosController : Controller
    {
        private InmobiliariaEntities db = new InmobiliariaEntities();

        // GET: /Inquilinos/
        public ActionResult Index()
        {
            var inquilinos = db.Inquilinos.Include(i => i.Cuenta_corriente1);
            return View(inquilinos.ToList());
        }

        // GET: /Inquilinos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inquilino inquilino = db.Inquilinos.Find(id);
            if (inquilino == null)
            {
                return HttpNotFound();
            }
            return View(inquilino);
        }

        // GET: /Inquilinos/Create
        public ActionResult Create()
        {
            ViewBag.nro_inquilino = new SelectList(db.Cuenta_corriente, "nro_inquilino", "nro_inquilino");
            return View();
        }

        // POST: /Inquilinos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="nro_inquilino,usuario,contrasena,nombre,apellido,direccion,telefono,dni,estado")] Inquilino inquilino)
        {
            if (ModelState.IsValid)
            {
                db.Inquilinos.Add(inquilino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.nro_inquilino = new SelectList(db.Cuenta_corriente, "nro_inquilino", "nro_inquilino", inquilino.nro_inquilino);
            return View(inquilino);
        }

        // GET: /Inquilinos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inquilino inquilino = db.Inquilinos.Find(id);
            if (inquilino == null)
            {
                return HttpNotFound();
            }
            ViewBag.nro_inquilino = new SelectList(db.Cuenta_corriente, "nro_inquilino", "nro_inquilino", inquilino.nro_inquilino);
            return View(inquilino);
        }

        // POST: /Inquilinos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="nro_inquilino,usuario,contrasena,nombre,apellido,direccion,telefono,dni,estado")] Inquilino inquilino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inquilino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.nro_inquilino = new SelectList(db.Cuenta_corriente, "nro_inquilino", "nro_inquilino", inquilino.nro_inquilino);
            return View(inquilino);
        }

        // GET: /Inquilinos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inquilino inquilino = db.Inquilinos.Find(id);
            if (inquilino == null)
            {
                return HttpNotFound();
            }
            return View(inquilino);
        }

        // POST: /Inquilinos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inquilino inquilino = db.Inquilinos.Find(id);
            db.Inquilinos.Remove(inquilino);
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
            var inquilinos = from m in db.Inquilinos
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                inquilinos = inquilinos.Where(s => s.apellido.Contains(searchString));
            }

            return View(inquilinos);
        }
    }
}
