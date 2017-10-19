using CadeOMedico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeOMedico.Controllers
{
    public class EspecialidadesController : Controller
    {
        private CadeOMedicoBDEntities1 db = new CadeOMedicoBDEntities1();
        //
        // GET: /Especialidades/

        public ActionResult Index()
        {
            var especialidades = db.Especialidades.ToList();
            return View(especialidades);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Especialidades especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Especialidades.Add(especialidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return ViewBag(especialidade);
        }

        public ActionResult Edit(long id)
        {
            Especialidades especialidade = db.Especialidades.Find(id);

            return View(especialidade);
        }

        [HttpPost]
        public ActionResult Edit(Especialidades especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(especialidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return ViewBag(especialidade);
        }

        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                Especialidades especialidade = db.Especialidades.Find(id);
                db.Especialidades.Remove(especialidade);
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
