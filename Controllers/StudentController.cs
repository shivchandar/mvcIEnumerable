using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcIEnumerable.Models;

namespace mvcIEnumerable.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student()
        {

            AmityDAL student = new AmityDAL();
            IEnumerable<Amity> strList = student.getStudent();

            return View(strList);
        }
    }
}