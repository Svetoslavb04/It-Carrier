using System;
using System.Linq;

namespace _4.PizzaCalories
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                var tokens = Console.ReadLine().Split();
                Pizza pizza = new Pizza(tokens[1]);
                tokens = Console.ReadLine().Split();
                pizza.Dough = new Dough(tokens[1], int.Parse(tokens[3]), tokens[2]);

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    tokens = command.Split();
                    Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
