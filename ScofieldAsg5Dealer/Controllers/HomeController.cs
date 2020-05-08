using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScofieldAsg10Cars.Models;

namespace ScofieldAsg10Cars.Controllers
{
    public class HomeController : Controller
    {
        private CarContext context { get; set; }

        public HomeController(CarContext ctx)
        {
            context = ctx;
        }
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
