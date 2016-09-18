using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Desafio.Models;
using System.Net;
using System.Data.Entity;

namespace Desafio.Controllers
{
    public class MercadoriasController : Controller
    {
        private MERCADORIASEntitdades db = new MERCADORIASEntitdades();

        // GET: Mercadorias
        public ActionResult Index()
        {
            return View(db.MERCADORIA.ToList());
        }

        //GET:Detalhes
        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MERCADORIA mercadoria = db.MERCADORIA.Find(id);

            if (mercadoria == null)
            {
                return HttpNotFound();
            }
            return View(mercadoria);
        }

        //GET: Adicionar
        public ActionResult Adicionar()
        {
            return View();
        }

        //POST: Adicionar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(MERCADORIA mercadoria)
        {
            if (ModelState.IsValid)
            {
                db.MERCADORIA.Add(mercadoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mercadoria);
        }

        //GET: Editar
        public ActionResult Alterar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MERCADORIA mercadoria = db.MERCADORIA.Find(id);

            if (mercadoria == null)
            {
                return HttpNotFound();
            }
            return View(mercadoria);

        }

        //POST: Alterar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(MERCADORIA mercadoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mercadoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mercadoria);
        }

        //GET: Excluir
        public ActionResult Excluir(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MERCADORIA mercadoria = db.MERCADORIA.Find(id);

            if (mercadoria == null)
            {
                return HttpNotFound();
            }
            return View(mercadoria);

        }

        //POST: Excluir
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(int id)
        {
            MERCADORIA mercadoria = db.MERCADORIA.Find(id);
            db.MERCADORIA.Remove(mercadoria);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}