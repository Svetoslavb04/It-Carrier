using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Program
    {
        public static void Main()
        {
            var supermarket = new Dictionary<string, List<double>>();

            while (true)
            {
                var input = Console.ReadLine().Split().ToList();

                if (input[0] == "stocked")
                {
                    break;
                }

                string name = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

                if (!supermarket.ContainsKey(name))
                {
                    var list = new List<double>();
                    list.Add(price);
                    list.Add(quantity);
                    supermarket.Add(name, list);
                }
                else
                {
                    supermarket[name][1] += quantity;

                    if (supermarket[name][0] != price)
                    {
                        supermarket[name][0] = price;
                    }
                }
            }

            double sum = 0;

            foreach (var item in supermarket)
            {
                Console.WriteLine($"{item.Key}: ${item.Value[0]:F2} * {item.Value[1]} = ${item.Value[0] * item.Value[1]:F2}");
                sum += item.Value[0] * item.Value[1];
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${sum:F2}");
        }
    }
}
