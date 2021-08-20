using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            if (type.ToLower() != "meat" && type.ToLower() != "veggies" && type.ToLower() != "cheese" && type.ToLower() != "sauce")
            {
                throw new Exception($"Cannot place {type} on top of your pizza.");
            }

            this.type = type.ToLower();

            if (weight < 0 || weight > 50)
            {
                throw new Exception($"{type} weight should be in the range [1..50].");
            }
            this.weight = weight;

            switch (this.type)
            {
                case "meat":
                    this.Calories = 2 * this.weight * 1.2;
                    break;
                case "veggies":
                    this.Calories = 2 * this.weight * 0.8;
                    break;
                case "cheese":
                    this.Calories = 2 * this.weight * 1.1;
                    break;
                case "sauce":
                    this.Calories = 2 * this.weight * 0.9;
                    break;
                default:
                    break;
            }
        }

        public double Calories { get; private set; }
        
    }
}
