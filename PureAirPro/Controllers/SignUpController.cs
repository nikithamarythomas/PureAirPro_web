﻿using Microsoft.AspNetCore.Mvc;

namespace PureAirPro.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
