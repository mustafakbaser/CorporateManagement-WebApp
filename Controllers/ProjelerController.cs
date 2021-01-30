using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RakamIKProjesi.Models.Siniflar;

namespace RakamIKProjesi.Controllers
{
    public class ProjelerController : Controller
    {
        // GET: Projeler
        Context context = new Context();
        public ActionResult Index()
        {
            var projeler = context.Projelers.ToList();
            return View(projeler);
        }

        [HttpGet]
        public ActionResult YeniProje()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniProje(Projeler proje)
        {
            context.Projelers.Add(proje);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ProjeTamamla(int id)
        {
            var projeDegeri = context.Projelers.Find(id);
            projeDegeri.ProjeAktifligi = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ProjeDevamEt(int id)
        {
            var projeDegeri = context.Projelers.Find(id);
            projeDegeri.ProjeAktifligi = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}