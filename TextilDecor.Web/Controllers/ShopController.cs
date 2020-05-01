using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextilDecor.Data.Models;
using TextilDecor.Data.Services;

namespace TextilDecor.Web.Controllers
{
    public class ShopController : Controller
    {
        IProduct db;

        public ShopController(IProduct db)
        {
            this.db = db;
        }

        // GET: Shop
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {


            if (ModelState.IsValid)
            {
                db.Add(product);
                return RedirectToAction("Index", new { id = product.Id });
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {


            if (ModelState.IsValid)
            {
                db.Update(product);
                TempData["Message"] = "You have saved the changes to product";
                return RedirectToAction("Index", new { id = product.Id });
            }

            return View(product);
        }
    }
}