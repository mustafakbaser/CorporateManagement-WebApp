using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RakamIKProjesi.Models.Siniflar;

namespace RakamIKProjesi.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        Context context = new Context();
        public ActionResult Index()
        {
            var veri1 = context.Projelers.Count(x => x.ProjeAktifligi == true).ToString();
            ViewBag.aktifProjeSayisi = veri1;

            var veri2 = context.Projelers.Count(x => x.ProjeAktifligi == false).ToString();
            ViewBag.pasifProjeSayisi = veri2;

            var veri3 = context.Personels.Count().ToString();
            ViewBag.personelSayisi = veri3;

            var veri4 = context.Personels.Count(x => x.PersonelAktif).ToString();
            ViewBag.aktifPersonel = veri4;

            var veri5 = context.Personels.Count(x => x.PersonelAktif == false).ToString();
            ViewBag.pasifPersonel = veri5;

            var veri6 = context.Personels.Count(x => x.DepartmanID == 1).ToString();
            ViewBag.yonetici = veri6;

            var veri7 = context.Personels.Count(x => x.DepartmanID == 2).ToString();
            ViewBag.programci = veri7;

            var veri8 = context.Personels.Count(x => x.DepartmanID == 3).ToString();
            ViewBag.tasarimci = veri8;

            var veri9 = context.Personels.Count(x => x.DepartmanID == 4).ToString();
            ViewBag.analist = veri9;

            var veri10 = context.Departmans.Count(x => x.Aktiflik == true).ToString();
            ViewBag.aktifDepartmanSayisi = veri10;

            var veri11 = context.Departmans.Count(x => x.Aktiflik == false).ToString();
            ViewBag.pasifDepartmanSayisi = veri11;

            return View();
        }
    }
}