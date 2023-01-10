using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_MAGAZA.Models.Entity;

namespace MVC_MAGAZA.Controllers
{
    public class SatıslarController : Controller
    {
        // GET: Satıslar
        MVCDbstokEntities db = new MVCDbstokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLSATISLAR.ToList();
            return View(degerler);
        }
    }
}