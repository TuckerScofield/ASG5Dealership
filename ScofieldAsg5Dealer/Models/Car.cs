using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ScofieldAsg10Cars.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string MakeModel { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }

    }
}
