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
        IProductData db;

        public OrderController(IProductData db)
        {
            this.db = db;
        }

        // GET: Order
        public ActionResult PaperMasks(int id)
        {
            var model = db.Get(id);
            return View(model);
        }
    }
}