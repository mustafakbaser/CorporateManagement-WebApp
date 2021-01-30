﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RakamIKProjesi.Models.Siniflar; // Veri listelemek için Models.Sınıflar'ı dahil ediyorum.

namespace RakamIKProjesi.Controllers
{
    public class DepartmanlarController : Controller
    {
        // GET: Departmanlar
        Context context = new Context(); // Context adında bir sınıf türettim
        public ActionResult Index()
        {
            var values = context.Departmans.ToList(); // String, int, bool gibi farklı veri tipleri olacağı için var tanımladım.
            return View(values);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost] //butona tıklayınca posttaki değer çalışacak
        public ActionResult DepartmanEkle(Departmanlar dep)
        {
            context.Departmans.Add(dep);
            context.SaveChanges(); //veritabanına kayıt, Ado.NET'deki ExecuteNonQuery'nin karşılığı
            return RedirectToAction("Index"); // Index'e yönlendirme
        }
        public ActionResult DepartmanSil(int id)
        {
            var dep = context.Departmans.Find(id);
            context.Departmans.Remove(dep);
            context.SaveChanges();
            return RedirectToAction("Index"); // Index'e yönlendirme
        }
        public ActionResult DepartmanVeri(int id)
        {
            var departman = context.Departmans.Find(id);
            return View("DepartmanVeri", departman);
        }
        public ActionResult DepartmanGuncelle(Departmanlar dep)
        {
            var depGuncelle = context.Departmans.Find(dep.DepartmanID);
            depGuncelle.DepartmanAd = dep.DepartmanAd; //dep değerinde tuttuğu veriyi veritabanındaki karşılığıyla değiştirecek/güncelleyecek
            depGuncelle.Aktiflik = dep.Aktiflik;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}