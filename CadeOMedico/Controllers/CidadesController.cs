using CadeOMedico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeOMedico.Controllers
{
    public class CidadesController : Controller
    {
        private CadeOMedicoBDEntities1 db = new CadeOMedicoBDEntities1();
        //
        // GET: /Cidades/

        public ActionResult Index()
        {
            var cidades = db.Cidades.ToList();
            return View(cidades);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cidades cidade)
        {
            if (ModelState.IsValid)
            {
                db.Cidades.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return ViewBag(cidade);
        }

        public ActionResult Edit(long id)
        {
            Cidades cidade = db.Cidades.Find(id);

            return View(cidade);
        }

        [HttpPost]
        public ActionResult Edit(Cidades cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(cidade);
        }

        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
               Cidades cidade = db.Cidades.Find(id);
                db.Cidades.Remove(cidade);
                db.SaveChanges();

                return Boolean.TrueString;

            }
            catch
            {
                return Boolean.FalseString;
            }
        }

    }
}
