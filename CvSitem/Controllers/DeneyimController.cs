using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvSitem.Models.Siniflar;
namespace CvSitem.Controllers
{
    [Authorize]
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        Context db = new Context();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Deneyimler()
        {
            var deneyim = db.Deneyimlers.ToList();
            return View(deneyim);
        }

        public ActionResult DeneyimSil(int id)
        {
            var deneyim2 = db.Deneyimlers.Find(id);
            db.Deneyimlers.Remove(deneyim2);
            db.SaveChanges();
            return RedirectToAction("Deneyimler");
            
        }

        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();

        }

        [HttpPost]
        public ActionResult DeneyimEkle(Deneyimler d)
        {
            db.Deneyimlers.Add(d);
            db.SaveChanges();
            return RedirectToAction("Deneyimler");
        }

        public ActionResult DeneyimGetir(int id)
        {
            var deneyim3 = db.Deneyimlers.Find(id);
            return View("DeneyimGetir", deneyim3);
        }

        public ActionResult DeneyimGuncelle(Deneyimler p)
        {
            var deneyim4 = db.Deneyimlers.Find(p.ID);
            deneyim4.Baslik = p.Baslik;
            deneyim4.AltBaslik = p.AltBaslik;
            deneyim4.Aciklama = p.Aciklama;
            deneyim4.Tarih = p.Tarih;
            db.SaveChanges();
            return RedirectToAction("Deneyimler");
        }
    }
}