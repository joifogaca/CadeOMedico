using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CadeOMedico.Models;

namespace CadeOMedico.Controllers
{
    public class MedicosController : Controller
    {
        //
        // GET: /Medicos/

        private CadeOMedicoBDEntities1 db = new CadeOMedicoBDEntities1();

        public ActionResult Index()
        {
            var medicos = db.Medicos.Include(m => m.Cidades)
                .Include(m => m.Especialidades).ToList();
            return View(medicos);
        }

        public ActionResult Adicionar()
        {

            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome");
            ViewBag.IDEspeciade = new SelectList(db.Especialidades, "IDEspecialidade", "Nome");
            return View();
        }

    }
}
