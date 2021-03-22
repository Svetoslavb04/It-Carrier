using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner_task
{
    public class Program
    {
        public static void Main()
        {
            var resources = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                else
                {
                    int quantity = int.Parse(Console.ReadLine());
                    if (resources.ContainsKey(input))
                    {
                        resources[input] += quantity;
                    }
                    else
                    {
                        resources.Add(input, quantity);
                    }
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
