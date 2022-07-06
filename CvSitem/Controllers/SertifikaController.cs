using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvSitem.Models.Siniflar;
namespace CvSitem.Controllers
{
    [Authorize]
    public class SertifikaController : Controller
    {
        Context db = new Context();
        // GET: Sertifika
        
        public ActionResult Sertifikalar()
        {
            var ser = db.Sertifikalars.ToList();
            return View(ser);
        }

        public ActionResult SertifikaSil(int id)
        {
            var ser = db.Sertifikalars.Find(id);
            db.Sertifikalars.Remove(ser);
            db.SaveChanges();
            return RedirectToAction("Sertifikalar");
        }
        
        [HttpGet]
        public ActionResult SertifikaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SertifikaEkle(Sertifikalar s)
        {
            db.Sertifikalars.Add(s);
            db.SaveChanges();
            return RedirectToAction("Sertifikalar");
        }

        public ActionResult SertifikaGetir(int id)
        {
            var ser2 = db.Sertifikalars.Find(id);
            return View("SertifikaGetir", ser2);
        }

        public ActionResult SertifikaGuncelle(Sertifikalar p)
        {
            var ser3 = db.Sertifikalars.Find(p.ID);
            ser3.Sertifika = p.Sertifika;
            db.SaveChanges();
            return RedirectToAction("Sertifikalar");
        }
    }
}