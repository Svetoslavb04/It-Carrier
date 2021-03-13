using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_of_names_2
{
    public class Program
    {
        public static void Main()
        {
            List<string> fullNames = Console.ReadLine().Split(',').ToList();

            foreach (var fullName in fullNames)
            {
                List<string> names = fullName.Split().ToList();
                names.Reverse();

                foreach (var name in names)
                {
                    Console.Write($"{name} ");
                }
                Console.WriteLine();
            }
        }
    }
}
