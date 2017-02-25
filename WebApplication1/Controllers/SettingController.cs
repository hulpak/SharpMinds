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
    public class SettingController : Controller
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
            return View(Db.Settings);
        }
        //Add  
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Settings off)
        {
            Db.Settings.Add(off);
            Db.SaveChanges();
            return View("Index");
        }

        //Edit

        public ActionResult Edit(int id)
        {
            Settings off = Db.Settings.Where(i => i.Id == id).FirstOrDefault();
            if (off == null)
            {
                return HttpNotFound();
            }
            return View("Edit", off);
        }

        [HttpPost]
        public ActionResult Edit(Settings off)
        {
            Db.Entry(off).State = EntityState.Modified;
            Db.SaveChanges();
            return View("Index");
        }

        //Delete
        public ActionResult Delete(int id)
        {
            Settings off = Db.Settings.Where(i => i.Id == id).FirstOrDefault();
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
            Settings off = Db.Settings.Where(i => i.Id == id).FirstOrDefault();

            if (off != null)
            {
                Db.Settings.Remove(off);
                Db.SaveChanges();
            }
            return View("Index");
        }

    }
}