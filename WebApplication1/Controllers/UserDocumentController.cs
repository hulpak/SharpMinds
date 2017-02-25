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
    public class UserDocumentController : Controller
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
            return View(Db.UserDocuments);
        }
        //Add  
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(UserDocument off)
        {
            Db.UserDocuments.Add(off);
            Db.SaveChanges();
            return View("Index");
        }

        //Edit

        public ActionResult Edit(int id)
        {
            UserDocument off = Db.UserDocuments.Where(i => i.Id == id).FirstOrDefault();
            if (off == null)
            {
                return HttpNotFound();
            }
            return View("Edit", off);
        }

        [HttpPost]
        public ActionResult Edit(UserDocument off)
        {
            Db.Entry(off).State = EntityState.Modified;
            Db.SaveChanges();
            return View("Index");
        }

        //Delete
        public ActionResult Delete(int id)
        {
            UserDocument off = Db.UserDocuments.Where(i => i.Id == id).FirstOrDefault();
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
            UserDocument off = Db.UserDocuments.Where(i => i.Id == id).FirstOrDefault();

            if (off != null)
            {
                Db.UserDocuments.Remove(off);
                Db.SaveChanges();
            }
            return View("Index");
        }

    }
}