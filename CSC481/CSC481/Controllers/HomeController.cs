﻿        using System;
        using System.Collections.Generic;
        using System.Diagnostics;
        using System.Linq;
        using System.Threading.Tasks;
        using Microsoft.AspNetCore.Mvc;
        using CSC481.Models;

        namespace CSC481.Controllers
        {
            public class HomeController : Controller
            {
                public IActionResult Index()
                {
                    return View();
                }

                public IActionResult About()
                {
                    ViewData["Message"] = "Your application description page.";

                    return View();
                }

                public IActionResult Contact()
                {
                    ViewData["Message"] = "Your contact page.";

                    return View();
                }
                public IActionResult Login()
                {
                    return View();
                }
                public IActionResult SignUp()
                {
                    return View();
                }
                public IActionResult Booking()
                {
                    return View();
                }
                
                public IActionResult Privacy()
                {
                    return View();
                }

                [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
                public IActionResult Error()
                {
                    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
                }
            }
        }
