using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloWordController : Controller
    {
        // GET: HelloWord
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            ViewBag.CC = "cccweq";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse gusetResponse)
        {
            if (ModelState.IsValid)
                //对晚会的组织者发送Email响应
                return View("Thanks", gusetResponse);
            else
                return View();
        }

    }
}