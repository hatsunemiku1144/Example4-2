using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRazor_Clone.Models;

namespace MVCRazor_Clone.Controllers
{
    public class RazorScoreController : Controller
    {
        // GET: RazorScore
        protected List<Student> students = new List<Student>
        {
            new Student { Id =1, Name="Joe", Chinese=88, English=95, Math=71 },
            new Student { Id =12, Name="Mary", Chinese=92, English=82, Math=60 },
            new Student { Id =23, Name="Cathy", Chinese=98, English=91, Math=94 },
            new Student { Id =34, Name="John", Chinese=63, English=85, Math=55 },
            new Student { Id =45, Name="David", Chinese=59, English=77, Math=82 }
        };
        public ActionResult Scores()
        {
            return View(students);
        }
        public ActionResult ScoresRazor()
        {

            int topID = 0, topScore = 0;
            foreach(var student in students)
            {
                student.Total = student.Math + student.Chinese + student.English;

                if (student.Total > topScore)
                {
                    topScore = student.Total;
                    topID = student.Id;
                }
            }
            ViewBag.TopId = Convert.ToInt32(topID);

           
            return View(students);
        }
        public ActionResult RazorScorePure()
        {
            return View(students);
        }
    }
}