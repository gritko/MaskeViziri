using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextilDecor.Data.Services;

namespace TextilDecor.Web.Controllers
{
    public class ProductController : Controller
    {
        IProduct db;

        public ProductController(IProduct db)
        {
            this.db = db;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}