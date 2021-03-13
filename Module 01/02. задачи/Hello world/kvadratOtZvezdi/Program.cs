using System;

namespace kvadratOtZvezdi
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine($"*{new string(' ', n - 2)}*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
