using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace virusBlockadaTestTask.ViewModels
{
    public class CarViewModel
    {
        [Required]
        public string Model { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Year { get; set; }

        public CarViewModel()
        {

        }

        public CarViewModel(string model, double price, string color, int year)
        {
            Model = model;
            Price = price;
            Color = color;
            Year = year;
        }
    }
}