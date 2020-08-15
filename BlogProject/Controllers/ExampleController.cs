using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Showmeapage()
        {
            return View();
        }
        public IActionResult ShowMeAnError()
        {
            return NotFound();
        }

        public IActionResult GiveMeAFile()
        {
            return File("/mydoc.txt", "text/plain");
        }

        public IActionResult GiveMeSomeJson()
        {
            string jsondata = "{Name:John-Luc Picard, Rank-Captain, Starship: Enterprise}";
            return Json(jsondata);
        }

        public IActionResult TakeMeToGoogle()
        {
            return Redirect("https://Google.com");
        }
    }
}
