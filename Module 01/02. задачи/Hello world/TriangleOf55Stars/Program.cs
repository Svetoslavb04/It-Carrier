using System;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int r = 0; r < i; r++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
