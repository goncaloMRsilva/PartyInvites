using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/Index
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 7 && hour < 12)
            {
                ViewBag.Mesasge = "Goood Morning";
            }
            else if (hour >= 12 && hour < 20)
            {
                ViewBag.Mesasge = "Good Afternoon";
            }
            else
            {
                ViewBag.Mesasge = "Good Night";
            }
            

            ViewBag.Mesasge = "Olá";
            return View();
        }

        //
        // GET: /HelloWorld/Welcome
        public string Welcome()
        {
            return "This is my Welcome action method...";
        }
    }
}
