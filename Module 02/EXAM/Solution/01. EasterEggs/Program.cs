using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EasterEggs
{
    public class Program
    {
        public static void Main()
        {
            var numberEggs = int.Parse(Console.ReadLine());
            var eggs = new Dictionary<string, int>();

            for (int i = 0; i < numberEggs; i++)
            {
                var colour = Console.ReadLine();

                if (eggs.ContainsKey(colour))
                {
                    eggs[colour]++;
                }
                else
                {
                    eggs.Add(colour, 1);
                }
            }

            if (eggs.ContainsKey("red"))
            {
                Console.WriteLine($"Red eggs: {eggs["red"]}");
            }
            else
            {
                Console.WriteLine($"Red eggs: 0");
            }

            if (eggs.ContainsKey("orange"))
            {
                Console.WriteLine($"Orange eggs: {eggs["orange"]}");
            }
            else
            {
                Console.WriteLine($"Orange eggs: 0");
            }

            if (eggs.ContainsKey("blue"))
            {
                Console.WriteLine($"Blue  eggs: {eggs["blue"]}");
            }
            else
            {
                Console.WriteLine($"Blue  eggs: 0");
            }

            if (eggs.ContainsKey("green"))
            {
                Console.WriteLine($"Green eggs: {eggs["green"]}");
            }
            else
            {
                Console.WriteLine($"Green eggs: 0");
            }

            var bestEgg = "";
            var bestEggCount = 0;

            foreach (var egg in eggs)
            {
                if (egg.Value > bestEggCount)
                {
                    bestEggCount = egg.Value;
                    bestEgg = egg.Key;
                }
            }

            Console.WriteLine($"Max eggs: {bestEggCount} -> {bestEgg}");
        }
    }
}
