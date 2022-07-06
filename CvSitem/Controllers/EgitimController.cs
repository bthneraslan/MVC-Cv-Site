using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvSitem.Models.Siniflar;
namespace CvSitem.Controllers
{
    [Authorize]
    public class EgitimController : Controller
    {
        Context db = new Context();
        // GET: Egitim
        public ActionResult Egitim()
        {
            var egitim = db.Egitims.ToList();
            return View(egitim);
        }

        public ActionResult EgitimSil(int id)
        {
            var egitim = db.Egitims.Find(id);
            db.Egitims.Remove(egitim);
            db.SaveChanges();
            return RedirectToAction("Egitim");
        }

        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EgitimEkle(Egitim e)
        {
            db.Egitims.Add(e);
            db.SaveChanges();
            return RedirectToAction("Egitim");
        }

        public ActionResult EgitimGetir(int id)
        {
            var egitim2 = db.Egitims.Find(id);
            return View("EgitimGetir", egitim2);
        }

        public ActionResult EgitimGuncelle(Egitim p)
        {
            var egitim3 = db.Egitims.Find(p.ID);
            egitim3.Baslik = p.Baslik;
            egitim3.AltBaslik = p.AltBaslik;
            egitim3.Aciklama = p.Aciklama;
            egitim3.GNO = p.GNO;
            egitim3.Tarih = p.Tarih;
            db.SaveChanges();
            return RedirectToAction("Egitim");
        }
    }
}