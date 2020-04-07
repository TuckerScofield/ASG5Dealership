using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScofieldAsg5Dealer.Models;

namespace ScofieldAsg6Dealer.Areas.Admin.Controllers
{
    public class CarController : Controller
    {
        

        [Area("Admin")]
        public IActionResult Index()
        {
            return View();

        }

        [Route("admin/car/list")]
        public IActionResult List()//C:\Users\16740073\source\repos\ScofieldAsg5Dealer\ScofieldAsg5Dealer\Areas\Admin\Views\Car\List.cshtml
        {
            List<Car> cars;
            cars = DB.sortByYear();

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

        //[HttpGet]
        //public IActionResult Update(int id)
        //{
        //    Car car = Car.ID;                      < --currently has an error

        //    ViewBag.Action = "Update";

        //    return View("AddUpdate", car);
        //}

        //[HttpPost]
        public IActionResult Update(Car car)
        {
            //car = new Car();

             DB.addCar(car);
           
            List<Car> cars;
            cars = DB.sortByYear();

            return View("~/Areas/Admin/Views/Car/List.cshtml", cars);

        }


    }
}