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
    public class HollyController : Controller
    {
        HRMContext db = new HRMContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //List
        public ActionResult List()
        {
            return View(db.OfficialHollidayses);
        }
        //Add  
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(OfficialHollidays off)
        {
            db.OfficialHollidayses.Add(off);
            db.SaveChanges();
            return View("Index");
        }

        //Edit

        public ActionResult Edit(int id)
        {
            OfficialHollidays off = db.OfficialHollidayses.Where(i => i.Id == id).FirstOrDefault();
            if (off == null)
            {
                return HttpNotFound();
            }
            return View("Edit", off);
        }

        [HttpPost]
        public ActionResult Edit(OfficialHollidays off)
        {
            db.Entry(off).State = EntityState.Modified;
            db.SaveChanges();
            return View("Index");
        }

        //Delete
        public ActionResult Delete(int id)
        {
            OfficialHollidays off = db.OfficialHollidayses.Where(i => i.Id == id).FirstOrDefault();
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
            OfficialHollidays off = db.OfficialHollidayses.Where(i => i.Id == id).FirstOrDefault();

            if (off != null)
            {
                db.OfficialHollidayses.Remove(off);
                db.SaveChanges();
            }
            return View("Index");
        }

    }
}