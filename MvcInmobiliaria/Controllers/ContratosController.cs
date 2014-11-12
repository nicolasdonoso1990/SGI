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
    public class ContratosController : Controller
    {
        private InmobiliariaEntities db = new InmobiliariaEntities();

        // GET: /Contratos/
        public ActionResult Index()
        {
            var contratos = db.Contratos.Include(c => c.Alquileres);
            return View(contratos.ToList());
        }

        // GET: /Contratos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = db.Contratos.Find(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // GET: /Contratos/Create
        public ActionResult Create()
        {
            ViewBag.nro_alquiler = new SelectList(db.Alquileres, "nro_alquiler", "estado");
            return View();
        }

        // POST: /Contratos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="cod_contrato,nro_alquiler,cod_unidad,nro_inquilino,fecha_realizacion,fecha_caducidad,descripcion_unidad,anexo")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                db.Contratos.Add(contrato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.nro_alquiler = new SelectList(db.Alquileres, "nro_alquiler", "estado", contrato.nro_alquiler);
            return View(contrato);
        }

        // GET: /Contratos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = db.Contratos.Find(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            ViewBag.nro_alquiler = new SelectList(db.Alquileres, "nro_alquiler", "estado", contrato.nro_alquiler);
            return View(contrato);
        }

        // POST: /Contratos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="cod_contrato,nro_alquiler,cod_unidad,nro_inquilino,fecha_realizacion,fecha_caducidad,descripcion_unidad,anexo")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contrato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.nro_alquiler = new SelectList(db.Alquileres, "nro_alquiler", "estado", contrato.nro_alquiler);
            return View(contrato);
        }

        // GET: /Contratos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = db.Contratos.Find(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // POST: /Contratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contrato contrato = db.Contratos.Find(id);
            db.Contratos.Remove(contrato);
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
    }
}
