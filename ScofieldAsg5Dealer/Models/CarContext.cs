using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ScofieldAsg10Cars.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }

        public enum SortOrder { ID, MakeModel, Year, Price, Mileage, Color }
        public static bool isAscYear { get; set; }
        public static bool isAscMake { get; set; }
        public static bool isAscModel { get; set; }
        public static bool isAscColor { get; set; }
        public static bool isAscPrice { get; set; }
        public static bool isAscMile { get; set; }
        public static bool isAscID { get; set; }

        private static List<Car> cars = new List<Car>();

        public static void addCar(Car car)
        {
            cars.Add(car);
        }

        public static void updateCar(Car updatedCar)
        {
            int id = updatedCar.ID;
            int carIndex = 0;
            carIndex = cars.FindIndex(o => o.ID == id);

            if (carIndex > -1)
                cars[carIndex] = updatedCar;
        }

        //use the enum as a parameter
        public static List<Car> sortBy(SortOrder sortOrder, bool isAcending)
        {
            List<Car> sortedList = new List<Car>();

            switch (sortOrder)
            {
                case SortOrder.ID:
                    {
                        if (isAscID)
                            sortedList = cars.OrderBy(o => o.ID).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.ID).ToList();

                        isAscID = !isAscID;
                        break;
                    }
                case SortOrder.MakeModel:
                    {
                        if (isAscMake)
                            sortedList = cars.OrderBy(o => o.MakeModel).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.MakeModel).ToList();

                        isAscMake = !isAscMake;
                        break;
                    }
                case SortOrder.Color:
                    {
                        if (isAscColor)
                            sortedList = cars.OrderBy(o => o.Color).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.Color).ToList();

                        isAscColor = !isAscColor;
                        break;
                    }
                case SortOrder.Mileage:
                    {
                        if (isAscMile)
                            sortedList = cars.OrderBy(o => o.Mileage).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.Mileage).ToList();

                        isAscMile = !isAscMile;

                        break;
                    }
                case SortOrder.Year:
                    {
                        if (isAscYear)
                            sortedList = cars.OrderBy(o => o.Year).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.Year).ToList();

                        isAscYear = !isAscYear;

                        break;
                    }
                case SortOrder.Price:
                    {
                        if (isAscPrice)
                            sortedList = cars.OrderBy(o => o.Price).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.Price).ToList();

                        isAscPrice = !isAscPrice;
                        break;
                    }
            }
            return sortedList;

        }

        public static List<Car> sortByYear()
        {
            List<Car> sortedList = new List<Car>();
            if (isAscYear == true)
                sortedList = cars.OrderBy(o => o.Year).ToList();
            else
                sortedList = cars.OrderByDescending(o => o.Year).ToList();

            isAscYear = !isAscYear;

            return sortedList;
        }



        public static Car GetCarByID(int id)
        {
            //Car foundCar = new Car();
            Car foundCar;

            //foreach (Car c in cars)
            //{
            //    if (c.ID == id)
            //        foundCar = c;
            //}
            foundCar = cars.Find(o => o.ID == id);
            return foundCar;
        }

        public static List<Car> GetCarByMakeModel(string MakeModel)
        {
            List<Car> foundCars = new List<Car>();
            //List<Car> cars = new List<Car>();

            //DB db = new DB();

            List<Car> cars = CarContext.sortByYear();

            foreach (Car c in cars)
            {
                if (c.MakeModel.Contains(MakeModel))
                    foundCars.Add(c);
            }
            return foundCars;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    ID = 1,
                    MakeModel = "Plymouth Horizon Hatch",
                    Year = 1983,
                    Price = 300,
                    Mileage = 65124,
                    Color = "Silver"
                },
                new Car
                {
                    ID = 2,
                    MakeModel = "Chevrolet Chevette",
                    Year = 1976,
                    Price = 450,
                    Mileage = 75894,
                    Color = "Burnt Orange"
                },
                new Car
                {
                    ID = 3,
                    MakeModel = "Ford F-150",
                    Year = 1987,
                    Price = 1200,
                    Mileage = 74358,
                    Color = "Red/White"
                },
                new Car
                {
                    ID = 4,
                    MakeModel = "Saab 900S",
                    Year = 1994,
                    Price = 2100,
                    Mileage = 64124,
                    Color = "Forest Green"
                }
            );
        }
    }
}
