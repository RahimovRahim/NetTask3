﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProniaAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBC _context;
        public HomeController(AppDBC context)
        {
            _context=context;
        }


        public IActionResult Index()

        {
            List<Models.Slider> slides = _context.sliders.ToList();
            return View(slides);
        }
    }

}


