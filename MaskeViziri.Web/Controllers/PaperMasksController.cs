using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaskeViziri.Data.Services;

namespace MaskeViziri.Web.Controllers
{
    public class PaperMasksController : Controller
    {
        IProductData db;

        public PaperMasksController(IProductData db)
        {
            this.db = db;
        }

        // GET: Masks
        public ActionResult Index(int id)
        {
            var model = db.Get(id);
            return View();
        }
    }
}