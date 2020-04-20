using MaskeViziri.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaskeViziri.Web.Controllers
{
    public class OrderController : Controller
    {
        IEquipmentData db;

        public OrderController(IEquipmentData db)
        {
            this.db = db;
        }

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
    }
}