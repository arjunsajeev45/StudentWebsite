using Microsoft.AspNetCore.Mvc;
using StudentWebsite.Helper;

namespace StudentWebsite.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetDetails(string name , int cls,int roll)
        {
            ViewBag.n = name;
            ViewBag.c = cls;
            ViewBag.r = roll;

            HelperClass obj = new HelperClass();
            obj.WriteaFile(name,cls, roll);
            return View();
        }


    }
}
