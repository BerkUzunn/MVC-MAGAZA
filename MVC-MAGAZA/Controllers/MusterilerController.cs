using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_MAGAZA.Models.Entity;

namespace MVC_MAGAZA.Controllers
{
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MVCDbstokEntities db = new MVCDbstokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERILER.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMüsteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMüsteri(TBLMUSTERILER p1)
        {
            db.TBLMUSTERILER.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}