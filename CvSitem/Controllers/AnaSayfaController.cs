using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvSitem.Models.Siniflar;
namespace CvSitem.Controllers
{
    
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context db = new Context();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Index2()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.Hakkindas.ToList();
            cs.Deger2 = db.Yeteneklers.ToList();
            cs.Deger3 = db.Hobilers.ToList();
            cs.Deger4 = db.Egitims.ToList();
            cs.Deger5 = db.Deneyimlers.ToList();
            cs.Deger6 = db.Sertifikalars.ToList();
            return View(cs);
        }

        [HttpGet]
        public PartialViewResult Partial1()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Partial1(İletisim p)
        {
            db.İletisims.Add(p);
            db.SaveChanges();
            return PartialView();
        }
    }
}