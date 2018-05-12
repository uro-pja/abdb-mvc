using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using zajecia5.Models;

namespace zajecia5.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Welcome(string name, int ID = 1) 
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = ID;
            return View();
        }
    }
}