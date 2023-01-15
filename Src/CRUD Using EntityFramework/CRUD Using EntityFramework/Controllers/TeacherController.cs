using CRUD_Using_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Using_EntityFramework.Controllers
{
    public class TeacherController : Controller
    {
        Teacher_Profile teacherData = new Teacher_Profile();
        // GET: Teacher
        public ActionResult Index()
        {
           var teachers= teacherData.tbl_Teacher.ToList();
            return View(teachers);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(tbl_Teacher t)
        {
            teacherData.tbl_Teacher.Add(t);
            teacherData.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = teacherData.tbl_Teacher.Where(x => x.TeacherID == Id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(tbl_Teacher t)
        {
            if (ModelState.IsValid)
            {
                teacherData.Entry(t).State = EntityState.Modified;
                teacherData.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var data = teacherData.tbl_Teacher.Where(x => x.TeacherID == Id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(int? Id)
        {
            tbl_Teacher tb = teacherData.tbl_Teacher.Find(Id);
            teacherData.tbl_Teacher.Remove(tb);
            teacherData.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}