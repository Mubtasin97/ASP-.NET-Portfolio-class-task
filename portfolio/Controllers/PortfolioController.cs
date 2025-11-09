using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            ViewBag.welcome = "Welcome";
            ViewBag.name = "Mubtasin Karim";
            ViewBag.outro1 = "A student of American International University Bangladesh.";
            ViewBag.outro2 = " I am currently in 10th semester. And this is my simple portfolio.";


            return View();
        }


        public ActionResult Bio()
        {
            var bio = new bio()
            { 
                Name="Mubtsin Karim",
                fName="Shazedul Karim",
                mName="Irin Parvin",
                Address="Badda, Dhaka",
                Dob="08-05-2002",
                Gender="Male",
                Religion="Islam",
            
            };
            return View(bio);
        }

        public ActionResult Projects()
        {
            var p1 = new projects()
            {
                Course = "Web Technologies",
                Title = "Book Shop",
                Description = "A book store management or library website showcasing projects and skills using HTML, CSS, and JavaScript.",
            };
            var p2 = new projects()
            {
                Course = "C#",
                Title = "Uthao",
                Description = "A car rental application using C# and mysql",
            };
            var p3 = new projects()
            {
                Course = "Java",
                Title = "Dhaka Wheels",
                Description = "A Java-based gui application that is used to find the best route and related bus service with fare.",
            };
              
            var pro = new projects[3] { p1,p2, p3};

            return View(pro);
        }

        public ActionResult Education()
        {
            var ed1 = new education()
            {
                Exam = "SSC",
                Gpa = "5.00",
                Institution = "Sristy College of Tangail",
                PassingYear = "2018",


            };
            var ed2 = new education()
            {
                Exam = "HSC",
                Gpa = "5.00",
                Institution = "Major General Mahmudul Hasan Ideal College, Tangail",
                PassingYear = "2020",


            };

            var edu = new education[2] { ed1, ed2 };



            return View(edu);
        }
        public ActionResult Reference()
        {
            return View();
        }
    }
}