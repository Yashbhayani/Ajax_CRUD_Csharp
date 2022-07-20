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

        public JsonResult SaveStudent(StudentDetails model)
        {
            return Json(model, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetStudentList()
        {    
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
