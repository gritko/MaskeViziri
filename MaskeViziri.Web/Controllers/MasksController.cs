using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaskeViziri.Data.Services;

namespace MaskeViziri.Web.Controllers
{
    public class MasksController : Controller
    {
        IEquipmentData db;

        public MasksController(IEquipmentData db)
        {
            this.db = db;
        }

        // GET: Masks
        public ActionResult Index()
        {
            return View();
        }
    }
}