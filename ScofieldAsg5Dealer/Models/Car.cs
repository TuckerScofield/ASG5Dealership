using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScofieldAsg5Dealer.Models
{
    public class Car
    {
        private static int id;  // Used as Auto Increment ID

        public static void setIDToZero()
        {
            id = 0;
        }
        public Car(string year, string makeModel, string price, string mileage, string color)
        {
            id++;  // Belongs to the Class, basically auto increment
            ID = id;
            MakeModel = makeModel;
            Year = int.Parse(year);
            Price = int.Parse(price);
            Mileage = int.Parse(mileage);
            Color = color;
        }
        public Car() { }
       


        public int ID { get; }
        public string MakeModel { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }

    }
}
