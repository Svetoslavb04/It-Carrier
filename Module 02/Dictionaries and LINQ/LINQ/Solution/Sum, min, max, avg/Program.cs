using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__min__max__avg
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
