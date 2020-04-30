using TextilDecor.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TextilDecor.Web.Controllers
{
    public class CartController : Controller
    {
        IProductData db;

        public CartController(IProductData db)
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