using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScofieldAsg5Dealer.Models;

namespace ScofieldAsg5Dealer.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(string id)
        {
            int carID;
            int.TryParse(id, out carID);

            DB db = new DB();

            Car car = db.GetCarByID(carID);
            return View(car);
        }

        [Route("Car/[action]")]
        public IActionResult List()
        {
            List<Car> cars = new List<Car>();
            DB db = new DB();
            cars = db.sortByYear();

            return View(cars);
        }

        [Route("Car/[action]/{orderby}")]

        public IActionResult List(string orderby)
        {
            //MakeModel, Year, Price, Milage, Color
            DB.SortOrder sortOrder;
            sortOrder = DB.SortOrder.Year;
            

            orderby = orderby.ToLower();
            switch (orderby)
            {
                case "id":
                    sortOrder = DB.SortOrder.ID;
                    break;
                case "make":
                    sortOrder = DB.SortOrder.MakeModel;
                    break;
                case "mileage":
                    sortOrder = DB.SortOrder.Mileage;
                    break;
                case "price":
                    sortOrder = DB.SortOrder.Price;
                    break;
                case "color":
                    sortOrder = DB.SortOrder.Color;
                    break;
                case "year":
                    sortOrder = DB.SortOrder.Year;
                    break;
            }

            DB db = new DB();
            List<Car> sortedCars = db.sortBy(sortOrder, true);
            return View(sortedCars);
        }

        public IActionResult Search(String id)
        {
            
            List<Car> foundCars = DB.GetCarByMakeModel(id);
            return View(foundCars);
        }
    }
}