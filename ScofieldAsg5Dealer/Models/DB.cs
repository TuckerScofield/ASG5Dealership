using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScofieldAsg5Dealer.Models
{
    public class DB
    {
        public enum SortOrder { ID,MakeModel, Year, Price, Mileage, Color }

        private List<Car> cars = new List<Car>();

        public DB()
        {

            //Add cars to the list
            loadCars();
        }

        //use the enum as a parameter
        public List<Car> sortBy(SortOrder sortOrder, bool isAcending)
        {
            List<Car> sortedList = new List<Car>();

            switch (sortOrder)
            {
                case SortOrder.ID:
                    {
                        if (isAcending)
                            sortedList = cars.OrderBy(o => o.ID).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.ID).ToList();
                        break;
                    }
                case SortOrder.MakeModel:
                    {
                        if (isAcending)
                            sortedList = cars.OrderBy(o => o.MakeModel).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.MakeModel).ToList();
                        break;
                    }
                case SortOrder.Color:
                    {
                        if (isAcending)
                            sortedList = cars.OrderBy(o => o.Color).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.Color).ToList();
                        break;
                    }
                case SortOrder.Mileage:
                    {
                        if (isAcending)
                            sortedList = cars.OrderBy(o => o.Mileage).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.Mileage).ToList();
                        break;
                    }
                case SortOrder.Year:
                    {
                        if (isAcending)
                            sortedList = cars.OrderBy(o => o.Year).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.Year).ToList();
                        break;
                    }
                case SortOrder.Price:
                    {
                        if (isAcending)
                            sortedList = cars.OrderBy(o => o.Price).ToList();
                        else
                            sortedList = cars.OrderByDescending(o => o.Price).ToList();
                        break;
                    }
            }
            return sortedList;

        }

        public List<Car> sortByYear()
        {
            List<Car> sortedList = new List<Car>();
            sortedList = cars.OrderBy(o => o.Year).ToList();

            sortedList = cars.OrderByDescending(o => o.Year).ToList();

            return sortedList;
        }



        private void loadCars()
        {
            cars.Add(new Car("2013", "Nissan Sentra", "8995", "84574", "Silver"));
            cars.Add(new Car("2014", "Chevrolet Spark LS", "8995", "35304", "Blue"));
            cars.Add(new Car("2013", "Ford Escape 4WD SE", "10900", "70873", "Blue"));
            cars.Add(new Car("2014", "Kia Soul", "10900", "54691", "White"));
            cars.Add(new Car("2013", "Hyundai Tucson AWD", "11900", "72115", "Green"));
            cars.Add(new Car("2018", "Nissan Versa", "11900", "44013", "Red"));
            cars.Add(new Car("2015", "Chevrolet Equinox AWD LS", "11900", "94401", "Silver"));
            cars.Add(new Car("2015", "Kia Sedona LX", "11900", "72751", "Red"));
            cars.Add(new Car("2016", "Hyundai Veloster", "11900", "49369", "White"));
            cars.Add(new Car("2011", "Cadillac DTS Luxury", "12900", "76443", "White"));
            cars.Add(new Car("2014", "Chevrolet Malibu LS w/ PROTECTION PACKAGE", "12900", "28232", "Blue"));
            cars.Add(new Car("2018", "Nissan Sentra", "13900", "37665", "White"));
            cars.Add(new Car("2014", "Subaru Crosstrek 2.0i Premium", "13900", "65360", "Tan"));
            cars.Add(new Car("2017", "Hyundai Elantra Sedan", "13900", "29059", "Blue"));
            cars.Add(new Car("2017", "Hyundai Elantra Sedan w/ CARGO PACKAGE", "14900", "25474", "White"));
            cars.Add(new Car("2016", "Dodge Grand Caravan SXT", "14900", "70812", "Black"));
            cars.Add(new Car("2016", "Jeep Cherokee 4WD Sport", "14900", "73122", "Silver"));
            cars.Add(new Car("2017", "Chevrolet Cruze LT Sedan", "14900", "20560", "Red"));
            cars.Add(new Car("2017", "Hyundai Elantra Sedan", "14900", "24851", "Red"));
            cars.Add(new Car("2014", "Cadillac CTS Sedan w/ SEATING PACKAGE", "14900", "69141", "Black"));
            cars.Add(new Car("2016", "Dodge Grand Caravan SXT", "15495", "70133", "White"));
            cars.Add(new Car("2017", "Nissan Altima", "15900", "14808", "Gray"));
            cars.Add(new Car("2017", "Chevrolet Trax AWD LS", "15900", "21027", "Silver"));
            cars.Add(new Car("2016", "Nissan Rogue AWD w/ SV PREMIUM PACKAGE", "15900", "53087", "Red"));
            cars.Add(new Car("2019", "Chevrolet Sonic LT Sedan w/ RS PACKAGE", "15900", "2928", "White"));
            cars.Add(new Car("2017", "Dodge Grand Caravan SXT", "15900", "68671", "Gray"));
            cars.Add(new Car("2016", "Buick Encore FWD Convenience", "15900", "17734", "Red"));
            cars.Add(new Car("2016", "Buick Encore AWD", "15900", "40059", "Gray"));
            cars.Add(new Car("2008", "Jeep Wrangler 4WD Sahara", "15900", "71164", "Silver"));
            cars.Add(new Car("2016", "Chevrolet Malibu LT", "15900", "42687", "Silver"));
            cars.Add(new Car("2017", "Hyundai Sonata SE", "15900", "30066", "Red"));
            cars.Add(new Car("2017", "Nissan Altima", "15900", "52533", "Gray"));
            cars.Add(new Car("2018", "Ford Focus SE Hatchback", "15900", "8040", "Yellow"));
            cars.Add(new Car("2015", "Honda Civic Si Coupe", "15900", "76904", "Blue"));
            cars.Add(new Car("2013", "Ford Explorer 4WD", "15900", "61089", "Black"));
            cars.Add(new Car("2017", "Nissan Altima", "16495", "30478", "White"));
            cars.Add(new Car("2013", "Cadillac XTS Luxury", "16900", "64693", "Silver"));
            cars.Add(new Car("2017", "Ford Fusion SE", "16900", "29494", "White"));
            cars.Add(new Car("2018", "Nissan Altima", "16900", "36416", "Red"));
            cars.Add(new Car("2019", "Nissan Sentra", "16900", "8749", "Blue"));
            cars.Add(new Car("2016", "Dodge Grand Caravan SE", "16900", "38075", "Red"));
            cars.Add(new Car("2017", "Chevrolet Equinox AWD LS", "16900", "35675", "Black"));
            cars.Add(new Car("2016", "GMC Terrain AWD SLE w/ SLE-1", "16900", "34019", "Red"));
            cars.Add(new Car("2016", "Hyundai Santa Fe AWD Sport w/ OPTION GROUP 03", "17495", "62375", "Blue"));
            cars.Add(new Car("2017", "Chevrolet Equinox AWD LT w/ CONVENIENCE PACKAGE", "17900", "37334", "Silver"));
            cars.Add(new Car("2016", "Buick Encore AWD Premium", "17900", "49013", "White"));
            cars.Add(new Car("2015", "Honda CR-V AWD EX-L", "17900", "73227", "Silver"));
            cars.Add(new Car("2016", "MAZDA CX-3 Grand Touring", "17900", "45925", "Blue"));
            cars.Add(new Car("2016", "Hyundai Tucson AWD", "17900", "32063", "Orange"));
            cars.Add(new Car("2015", "Toyota RAV4 AWD Limited", "17900", "69173", "Red"));

            cars.Add(new Car("1983", "Plymouth Horizon Hatch", "300", "65124", "Silver"));
            cars.Add(new Car("1976", "Chevrolet Chevette", "450", "75894", "Burnt Orange"));
            cars.Add(new Car("1987", "Ford F-150 F-Series", "1200", "74358", "Red/White"));
            cars.Add(new Car("1994", "Saab 900S", "2100", "64124", "Forest Green"));


            Car.setIDToZero();

        }

       

        public  Car GetCarByID(int id)
        {
            Car foundCar = new Car();

            foreach (Car c in cars)
            {
                if (c.ID == id)
                    foundCar = c;
            }
            return foundCar;
        }

        public static List<Car> GetCarByMakeModel(string MakeModel)
        {
            List<Car> foundCars = new List<Car>();
            List<Car> cars = new List<Car>();

            //List<Car> allCars = DB.GetCars();

            foreach (Car c in cars)
            {
                if (c.MakeModel == MakeModel)
                    foundCars.Add(c);
            }
            return foundCars;
        }
    }
}
