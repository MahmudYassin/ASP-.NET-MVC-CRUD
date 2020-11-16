using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using day2WebApp.Models;

namespace day2WebApp.Controllers
{
    public class StudentController : Controller
    {
        public static List<student> students = new List<student>()
        {
            new student{id= 1, name="mahmoud", age=25 },
            new student{id= 2, name="mohamed", age=30 },
            new student{id= 3, name="ahmed", age=20 },
            new student{id= 4, name="ali", age=40 },

        };
        public ActionResult Index()
        {
            return View(students);
        }

        public ActionResult create(int id , string name , int age)
        {
            student std = new student {id =id , name=name,age=age };
            students.Add(std);
            return RedirectToAction("Index");
        }

        public ActionResult createview()
        {
            return View();
        }

        public ActionResult details(int id)
        {
            student std = students.FirstOrDefault(s => s.id == id);
            return View(std);
        }
        public ActionResult updateview(int id)
        {
            student std = students.FirstOrDefault(s => s.id == id);
            return View(std);
        }
        public ActionResult update(int id, string name, int age)
        {
            student std = students.FirstOrDefault(s => s.id == id);
            std.name = name;
            std.age = age;
            return RedirectToAction("Index");
        }

        public ActionResult delete(int id)
        {
            student std = students.FirstOrDefault(s => s.id == id);
            students.Remove(std);
            return RedirectToAction("Index");
        }
        public ActionResult warning(int id)
        {
            return View(id);
        }
    }
}