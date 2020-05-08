using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScofieldAsg10Cars.Models;


namespace ScofieldAsg10Cars.Areas.Admin.Controllers
{
    public class CarController : Controller
    {

        private CarContext context { get; set; }
        public CarController(CarContext ctx)
        {
            context = ctx;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            return View();

        }

        [Route("admin/car/list")]
        public IActionResult List()//C:\Users\16740073\source\repos\ScofieldAsg5Dealer\ScofieldAsg5Dealer\Areas\Admin\Views\Car\List.cshtml
        {
            var cars = context.Cars.OrderBy(c => c.Year).ToList();

            // return Content("Cars  List");
            return View("~/Areas/Admin/Views/Car/List.cshtml", cars);
        }

        //[HttpGet]
        public IActionResult Add()
        {
            Car car = new Car();

            ViewBag.Action = "Add";

            return View("~/Areas/Admin/Views/Car/AddUpdate.cshtml", car);
        }

    }
}