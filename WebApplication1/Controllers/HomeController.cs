using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        HRMContext db = new HRMContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
               
        //List
        public ActionResult List() {
            return View(db.Users);
        }
     //Add  

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(UserVM user)
        {
            User u = new HRM.DAL.Models.User();
            u.FullName = user.FullName;
            u.Email = u.Email;
            u.LevelId = u.LevelId;
            u.Password = user.Password;
            u.StartDate = user.StartDate;
            u.StatusId = u.StatusId;
                db.Users.Add(u);
                db.SaveChanges();
                return View("List");
            
        }
//Edit

        public ActionResult Edit(int id)
        {
            User user = db.Users.Find(id);  
            if (user == null)
            {
                return HttpNotFound();
            }
            return View("Edit",user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete
        public ActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                return PartialView("Delete", user);
            }
            return View("Index");
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int id)
        {
            User user = db.Users.Where(i=>i.Id == id).FirstOrDefault();

            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

    }
}