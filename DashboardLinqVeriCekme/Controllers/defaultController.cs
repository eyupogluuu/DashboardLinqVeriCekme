using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DashboardLinqVeriCekme.Models.Entity;

namespace DashboardLinqVeriCekme.Controllers
{
    public class defaultController : Controller
    {
        UrunTakipDBEntities db = new UrunTakipDBEntities();
        // GET: default
        public ActionResult Index()
        {
            var kategori = db.Kategori.Count();
            ViewBag.ktgr = kategori;

            var musteri = db.Musteri.Count();
            ViewBag.mst = musteri;

            var urun = db.Urun.Count();
            ViewBag.urn = urun;

            var satis = db.Satis.Count();
            ViewBag.sts = satis;

            return View();
        }
    }
}