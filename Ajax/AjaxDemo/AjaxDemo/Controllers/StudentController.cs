using AjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class StudentController : Controller
    {
        public List<StudentDetails> lstStudents = new List<StudentDetails>();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddStudent()
        {
            return View();
        }

      /*  [HttpPost]*/
        public JsonResult SaveStudent(StudentDetails model)
        {
           /* lstStudents.Add(new StudentDetails
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName
            });*/
            return Json(model, JsonRequestBehavior.AllowGet);
            //return Json("GetStudentList");
        }


        public JsonResult GetStudentList()
        {
          /*  List<StudentDetails> lstStudents = new List<StudentDetails>();*/
                
            lstStudents.Add(new StudentDetails
            {
                FirstName = "Hardik",
                Id = "1",
                LastName = "Patel"
            });

            lstStudents.Add(new StudentDetails
            {
                FirstName = "Evaan",
                Id = "2",
                LastName = "Patel"
            });


            return Json(lstStudents, JsonRequestBehavior.AllowGet);
        }
    }
}