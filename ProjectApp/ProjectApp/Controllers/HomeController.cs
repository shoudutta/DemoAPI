using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectApp.Controllers
{
    public class HomeController : Controller
    {
        EmpDbContext db = new EmpDbContext();
        // GET: Home
        public ActionResult Index()
        {
            DisplayModel model = new DisplayModel{
            str="Welcome to my project"
            };
            return View(model);
        }
        public ActionResult Enter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Enter(EmpModel model)
        {
            db.Employees.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Display()
        {
            db.Employees.Select(x => x.empId > 0);
            return View(db.Employees.ToList());
        }
    }
}