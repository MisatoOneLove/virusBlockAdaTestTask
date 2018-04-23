using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataAcess.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car()
        {
            
        }

        public Car(string model, double price, string color, int year)
        {
            Model = model;
            Price = price;
            Color = color;
            Year = year;
        }
    } 
}