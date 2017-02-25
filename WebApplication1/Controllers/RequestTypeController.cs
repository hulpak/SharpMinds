using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RequestTypeController : Controller
    {
        HRMContext Db = new HRMContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //List
        public ActionResult List()
        {
            return View(Db.RequestType);
        }
        //Add  
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(RequestType off)
        {
            Db.RequestType.Add(off);
            Db.SaveChanges();
            return View("Index");
        }

        //Edit

        public ActionResult Edit(int id)
        {
            RequestType off = Db.RequestType.Where(i => i.Id == id).FirstOrDefault();
            if (off == null)
            {
                return HttpNotFound();
            }
            return View("Edit", off);
        }

        [HttpPost]
        public ActionResult Edit(RequestType off)
        {
            Db.Entry(off).State = EntityState.Modified;
            Db.SaveChanges();
            return View("Index");
        }

        //Delete
        public ActionResult Delete(int id)
        {
            RequestType off = Db.RequestType.Where(i => i.Id == id).FirstOrDefault();
            if (off != null)
            {
                return PartialView("Delete", off);
            }
            return View("Index");
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int id)
        {
            RequestType off = Db.RequestType.Where(i => i.Id == id).FirstOrDefault();

            if (off != null)
            {
                Db.RequestType.Remove(off);
                Db.SaveChanges();
            }
            return View("Index");
        }

    }
}