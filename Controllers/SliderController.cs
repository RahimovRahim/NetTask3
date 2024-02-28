using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using ProniaAdmin.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProniaAdmin.Controllers
{
    public class SliderController : Controller
    {
        AppDBC _context;
        public SliderController(AppDBC context)
        {
            _context = context;
           
        }

        public IActionResult Index()
        {
            List<Slider> sliderList = _context.sliders.ToList();
            return View(sliderList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            return View();
        }
    }
}

