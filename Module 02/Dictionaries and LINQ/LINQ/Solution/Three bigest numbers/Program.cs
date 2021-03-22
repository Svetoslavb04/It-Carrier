using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_bigest_numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .OrderByDescending(x => x)
                .ToList();

            Console.WriteLine(string.Join(" ",numbers.Take(3)));
        }
    }
}
