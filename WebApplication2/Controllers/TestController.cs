using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorEngine;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(string userInput)
        {
            ViewBag.UserText = userInput;
            ViewBag.DangerousOutput = Razor.Parse("<h3>" + userInput + "</h3>");
            return View();
        }
    }
}