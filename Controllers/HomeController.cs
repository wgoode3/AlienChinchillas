using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AlienChinchillas.Controllers
{
    public class HomeController : Controller
    {

        public static List<string> chinchillaNames = new List<string>()
        {
            "Mr Nibbles",
            "Jackie",
            "Benny Bob",
            "Billy Bob",
            "Rick",
            "Jose"
        };

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.chinchillaNames = chinchillaNames;
            return View();
        }

        [HttpGet("another")]
        public IActionResult Another()
        {
            return View("Something");
        }

        [HttpPost("process")]
        public IActionResult Process(string name)
        {
            chinchillaNames.Add(name);
            return Redirect("/");
        }

    }
}