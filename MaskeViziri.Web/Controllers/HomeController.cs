using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaskeViziri.Data.Services;

namespace MaskeViziri.Web.Controllers
{
    public class HomeController : Controller
    {
        IEquipmentData db;

        public HomeController(IEquipmentData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            Citam sve 
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}