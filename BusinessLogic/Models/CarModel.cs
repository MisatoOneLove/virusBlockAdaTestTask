using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BusinessLogic.Models
{
    public class CarModel
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public CarModel()
        {

        }

        public CarModel(string model, double price, string color, int year)
        {
            Model = model;
            Price = price;
            Color = color;
            Year = year;
        }
    }
}