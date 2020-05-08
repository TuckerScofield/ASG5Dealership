using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScofieldAsg10Cars.Models;
using Microsoft.EntityFrameworkCore;

namespace ScofieldAsg10Cars.Controllers
{
    public class CarController : Controller
    {
        private CarContext context { get; set; }
        public CarController(CarContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            var car = context.Cars.Find(id);
            return View(car);
        }

        [Route("/cars")]    // URL:  https://localhost:5001/cars
        public IActionResult List()
        {
            var cars = context.Cars.OrderBy(c => c.Year).ToList();
            return View(cars);
        }

        [Route("cars/list/{orderby?}")]  // URL:  https://localhost:5001/cars/list/color
        public IActionResult List(string orderby)
        {
            // Andy:  Check for null
            if (orderby == null)
                orderby = "";

            //MakeModel, Year, Price, Milage, Color
            CarContext.SortOrder sortOrder;
            sortOrder = CarContext.SortOrder.Year;


            orderby = orderby.ToLower();
            switch (orderby)
            {
                case "id":
                    sortOrder = CarContext.SortOrder.ID;
                    break;
                case "make":
                    sortOrder = CarContext.SortOrder.MakeModel;
                    break;
                case "mileage":
                    sortOrder = CarContext.SortOrder.Mileage;
                    break;
                case "price":
                    sortOrder = CarContext.SortOrder.Price;
                    break;
                case "color":
                    sortOrder = CarContext.SortOrder.Color;
                    break;
                case "year":
                    sortOrder = CarContext.SortOrder.Year;
                    break;
            }

            List<Car> sortedCars = CarContext.sortBy(sortOrder, true);
            return View(sortedCars);
        }



        public IActionResult Search(String id)
        {
            List<Car> foundCars = CarContext.GetCarByMakeModel(id);
            return View(foundCars);
        }
    }
}