﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EternaApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

    }
}