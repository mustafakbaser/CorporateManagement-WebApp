using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RakamIKProjesi.Models.Siniflar;

namespace RakamIKProjesi.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Personels.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult PersonelEkle()
        {
            List<SelectListItem> personelDeger = (from p in context.Departmans.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = p.DepartmanAd,
                                                      Value = p.DepartmanID.ToString()
                                                  }).ToList();
            ViewBag.yeniPersonelDepartman = personelDeger;
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(Personel p)
        {
            context.Personels.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelVeri(int id)
        {
            List<SelectListItem> personelDeger = (from p in context.Departmans.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = p.DepartmanAd,
                                                      Value = p.DepartmanID.ToString()
                                                  }).ToList();
            ViewBag.yeniPersonelDepartman = personelDeger;
            var personel = context.Personels.Find(id);
            return View("PersonelVeri", personel);
        }

        public ActionResult PersonelGuncelle(Personel p)
        {
            var pers = context.Personels.Find(p.PersonelID);
            pers.PersonelAd = p.PersonelAd;
            pers.Birim = p.Birim;
            pers.DepartmanID = p.DepartmanID;
            pers.PersonelAktif = p.PersonelAktif;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}