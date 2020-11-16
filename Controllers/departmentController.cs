using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using day2WebApp.Models;

namespace day2WebApp.Controllers
{
    public class departmentController : Controller
    {
        public static List<department> departments = new List<department>()
        {
            new department{id= 1, name="sd" },
            new department{id= 2, name="hr" },
        };
        public ActionResult Index()
        {
            return View(departments);
        }

        public ActionResult create(int id, string name)
        {
            department dep = new department { id = id, name = name};
            departments.Add(dep);
            return RedirectToAction("Index");
        }

        public ActionResult createview()
        {
            return View();
        }

        public ActionResult details(int id)
        {
            department dep = departments.FirstOrDefault(s => s.id == id);
            return View(dep);
        }
        public ActionResult updateview(int id)
        {
            department dep = departments.FirstOrDefault(s => s.id == id);
            return View(dep);
        }
        public ActionResult update(int id, string name)
        {
            department dep = departments.FirstOrDefault(s => s.id == id);
            dep.name = name;
            return RedirectToAction("Index");
        }

        public ActionResult delete(int id)
        {
            department dep = departments.FirstOrDefault(s => s.id == id);
            departments.Remove(dep);
            return RedirectToAction("Index");
        }
        public ActionResult warning(int id)
        {
            return View(id);
        }
    }
}