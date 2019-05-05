﻿using Microsoft.AspNetCore.Mvc;

namespace taskr_users_api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var test = "this is a test";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return BadRequest();
        }
    }
}
