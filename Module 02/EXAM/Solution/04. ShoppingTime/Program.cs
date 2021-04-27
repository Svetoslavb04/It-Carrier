using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ShoppingTime
{
    public class Program
    {
        public static void Main()
        {
            var shoppingCart = new SortedDictionary<string, decimal>();
            decimal sum = 0;

            while (true)
            {
                var input = Console.ReadLine().Split('-').ToList();

                if (input[0] == "Stop shopping")
                {
                    break;
                }

                string product = input[0];
                decimal productPrice = decimal.Parse(input[1]);

                if (!shoppingCart.ContainsKey(product))
                {
                    if (productPrice > 0)
                    {
                        shoppingCart.Add(product, productPrice);
                    }
                }
                else
                {
                    shoppingCart[product] += productPrice;
                }

                sum += productPrice;
            }

            foreach (var prod in shoppingCart.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{prod.Key} -> {Math.Round(prod.Value, 2)}");
            }

            Console.WriteLine($"Total sum: {Math.Round(sum, 2)}");

        }
    }
}
