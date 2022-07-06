using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvSitem.Models.Siniflar;
namespace CvSitem.Controllers
{
    [Authorize]
    public class HobiController : Controller
    {
        Context db = new Context();
        // GET: Hobi
        public ActionResult Hobiler()
        {
            var hobi = db.Hobilers.ToList();
            return View(hobi);
        }

        public ActionResult HobiSil(int id)
        {
            var hobi2 = db.Hobilers.Find(id);
            db.Hobilers.Remove(hobi2);
            db.SaveChanges();
            return RedirectToAction("Hobiler");
        }

        [HttpGet]
        public ActionResult HobiEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HobiEkle(Hobiler h)
        {
            db.Hobilers.Add(h);
            db.SaveChanges();
            return RedirectToAction("Hobiler");
        }

        public ActionResult HobiGetir(int id)
        {
            var hobi3 = db.Hobilers.Find(id);
            return View("HobiGetir", hobi3);
        }

        public ActionResult HobiGuncelle(Hobiler p)
        {
            var hobi4 = db.Hobilers.Find(p.ID);
            hobi4.Hobi = p.Hobi;
            db.SaveChanges();
            return RedirectToAction("Hobiler");
        }
    }
}