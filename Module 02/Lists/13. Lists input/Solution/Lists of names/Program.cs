using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_of_names
{
    public class Program
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Console.WriteLine(string.Join("; ", names));
        }
    }
}
