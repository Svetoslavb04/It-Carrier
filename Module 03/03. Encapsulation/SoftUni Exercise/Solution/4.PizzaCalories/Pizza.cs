using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;
        private int numberOfToppings;
        private double totalCalories;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
            this.numberOfToppings = 0;
        }

        public Dough Dough
        {
            private get { return this.dough; }
            set 
            { 
                this.dough = value;
                this.TotalCalories = value.Calories;
            }
        }

        public double TotalCalories
        {
            get { return this.totalCalories; }
            private set { this.totalCalories = value; }
        }

        public int NumberOfToppings
        {
            get { return this.numberOfToppings; }
            private set { this.numberOfToppings = value; }
        }


        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (value.Length < 0 || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value; 
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.numberOfToppings + 1 > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
            this.numberOfToppings++;

            this.totalCalories += topping.Calories;
        }
    }
}
