using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvSitem.Models.Siniflar;
namespace CvSitem.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        Context db = new Context();
        public ActionResult Index(int id = 1)
        {
            var hakkimda = db.Hakkindas.Find(id);
            return View("Index", hakkimda);
        }


        public ActionResult HakkimdaGuncelle(Hakkinda h)
        {
            var hak = db.Hakkindas.Find(h.ID);
            hak.Ad = h.Ad;
            hak.Soyad = h.Soyad;
            hak.Adres = h.Adres;
            hak.Mail = h.Mail;
            hak.Telefon = h.Telefon;
            hak.KisaNot = h.KisaNot;
            hak.Fotograf = h.Fotograf;
            db.SaveChanges();
            return View("Index");
        }

        public ActionResult İletisim()
        {
            var ile = db.İletisims.ToList();
            return View(ile);
        }

        public ActionResult MesajSil(int id)
        {
            var ilt = db.İletisims.Find(id);
            db.İletisims.Remove(ilt);
            db.SaveChanges();
            return RedirectToAction("İletisim");
        }

    }
}