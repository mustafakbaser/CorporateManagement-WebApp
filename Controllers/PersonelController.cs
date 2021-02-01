using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RakamIKProjesi.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace RakamIKProjesi.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        Context context = new Context();
        public ActionResult Index(string p)
        {
            var personeller = from x in context.Personels select x;
            if (!string.IsNullOrEmpty(p))
            {
                personeller = personeller.Where(y => y.PersonelAd.Contains(p));
            }
            return View(personeller.ToList());
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

            List<SelectListItem> personelProje = (from p in context.Projelers.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = p.ProjeAd,
                                                      Value = p.ProjeID.ToString()
                                                  }).ToList();
            ViewBag.personelProjeKaydi = personelProje;
            

            List<SelectListItem> birimKayit = (from p in context.Birims.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = p.BIRIM,
                                                   Value = p.BirimID.ToString()
                                               }).ToList();
            ViewBag.birimKayit = birimKayit;
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

            List<SelectListItem> projeyeKayit = (from p in context.Projelers.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = p.ProjeAd,
                                                      Value = p.ProjeID.ToString()
                                                  }).ToList();
            ViewBag.projeyeKayit = projeyeKayit;

            List<SelectListItem> birimKayit = (from p in context.Birims.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = p.BIRIM,
                                                     Value = p.BirimID.ToString()
                                                 }).ToList();
            ViewBag.birimKayit = birimKayit;

            var personel = context.Personels.Find(id);
            return View("PersonelVeri", personel);
        }

        public ActionResult PersonelGuncelle(Personel p)
        {
            var pers = context.Personels.Find(p.PersonelID);
            pers.PersonelAd = p.PersonelAd;
            pers.BirimID = p.BirimID;
            pers.DepartmanID = p.DepartmanID;
            pers.PersonelAktif = p.PersonelAktif;
            pers.ProjeID = p.ProjeID;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}