using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvSitem.Models.Siniflar;
namespace CvSitem.Controllers
{
    [Authorize]
    public class YetenekController : Controller
    {
        Context db = new Context();
        // GET: Yetenek
        public ActionResult Yetenekler()
        {
            var yetenek = db.Yeteneklers.ToList();
            return View(yetenek);
        }

        public ActionResult YetenekSil(int id)
        {
            var yetenek = db.Yeteneklers.Find(id);
            db.Yeteneklers.Remove(yetenek);
            db.SaveChanges();
            return RedirectToAction("Yetenekler");
        }

        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YetenekEkle(Yetenekler y)
        {
            db.Yeteneklers.Add(y);
            db.SaveChanges();
            return RedirectToAction("Yetenekler");
        }

        public ActionResult YetenekGetir(int id)
        {
            var yetenek2 = db.Yeteneklers.Find(id);
            return View("YetenekGetir", yetenek2);
        }

        public ActionResult YetenekGuncelle(Yetenekler p)
        {
            var yetenek3 = db.Yeteneklers.Find(p.ID);
            yetenek3.Yetenek = p.Yetenek;
            db.SaveChanges();
            return RedirectToAction("Yetenekler");
        }
    }
}