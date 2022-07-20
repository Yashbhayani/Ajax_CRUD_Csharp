using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Useinfo()
        {
            return View();
        }

        [HttpPost]
/*        [ActionName("Useinfo1")]*/
        public ActionResult UserDetails()
        {
            string UserName = Convert.ToString(Request["firstName"].ToString());
            string UserSurName = Convert.ToString(Request["lastname"].ToString());
            string UserAge = Convert.ToString(Request["age"].ToString());

            StringBuilder UserInterset = new StringBuilder();
            UserInterset.Append("<h4>FirstName:- <h5>" + UserName + " </h5> </h4>");
            UserInterset.Append("<h4>SurName:- <h5>" + UserSurName + " </h5></h4>");
            UserInterset.Append("<h4>FirstName:- <h5>" + UserAge + " </h5></h4>");
            return Content(UserInterset.ToString());
        }
    }
}