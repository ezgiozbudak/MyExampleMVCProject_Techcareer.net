using randevuMVC.Models;
using randevuMVC.Veriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace randevuMVC.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Goster()
        {
            return View(MusteriVerileri.musteriler);
        }

        public ActionResult Kayit ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kayit(Musteri musteri)
        {
            MusteriVerileri.musteriler.Add(musteri);
            return RedirectToAction("Goster");
        }

        public ActionResult Guncelle(int id)
        {
            var musterimiz = MusteriVerileri.musteriler.Where(x => x.Id == id).FirstOrDefault();
            return View(musterimiz);
       
        }

        [HttpPost]
        public ActionResult Guncelle(Musteri m)
        {
            Musteri musteri = MusteriVerileri.musteriler.Where(x => x.Id == m.Id).FirstOrDefault();
            musteri.Ad = m.Ad;
            musteri.Soyad= m.Soyad;
            musteri.Email = m.Email;
            musteri.TelefonNo = m.TelefonNo;

            return RedirectToAction("Goster");
        }
    }
}