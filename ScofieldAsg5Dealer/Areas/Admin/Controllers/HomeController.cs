using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScofieldAsg10Cars.Models;

namespace ScofieldAsg10Cars.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private CarContext context { get; set; }
        public HomeController(CarContext ctx)
        {
            context = ctx;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}