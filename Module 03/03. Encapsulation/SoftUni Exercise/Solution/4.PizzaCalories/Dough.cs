using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PizzaCalories
{
    public class Dough
    {
        private string flour;
        private string bakingTechnique;
        private double weight;

        public Dough(string flour, double weight, string bakingTechnique)
        {
            if (flour.ToLower() != "white" && flour.ToLower() != "wholegrain")
            {
                throw new Exception("Invalid type of dough.");
            }

            this.flour = flour.ToLower();

            if (weight < 0 || weight > 200)
            {
                throw new Exception("Dough weight should be in the range [1..200].");
            }

            this.weight = weight;

            if (bakingTechnique.ToLower() != "crispy" && bakingTechnique.ToLower() != "chewy" && bakingTechnique.ToLower() != "homemade")
            {
                throw new Exception("Invalid type of dough.");
            }

            switch (this.flour)
            {
                case "white":
                    this.Calories = weight * 2 * 1.5;
                    break;
                case "wholegrain":
                    this.Calories = weight * 2;
                    break;
                default:
                    break;
            }

            this.bakingTechnique = bakingTechnique.ToLower();

            switch (this.bakingTechnique)
            {
                case "crispy":
                    this.Calories = this.Calories * 0.9;
                    break;
                case "chewy":
                    this.Calories = this.Calories * 1.1;
                    break;
                default:
                    break;
            }
        }
        public double Calories { get; private set; }

    }
}

