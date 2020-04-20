using MaskeViziri.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaskeViziri.Web.Controllers
{
    public class CartController : Controller
    {
        IEquipmentData db;

        public CartController(IEquipmentData db)
        {
            this.db = db;
        }

        // GET: Cart
        public ActionResult Index(int id)
        {
            var model = db.Get(id);
            return View();
        }
    }
}