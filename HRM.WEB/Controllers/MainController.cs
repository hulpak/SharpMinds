using HRM.DAL.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRM.Web.Controllers
{
    public class MainController : Controller
    {
        HRMContext db = new HRMContext();
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Details() {
        //    return View(db.Teams);
        //}
    }
}